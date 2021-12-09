using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesClusterization
{
    public partial class MainForm : Form
    {
        CountrySQLiteController dbController;
        Clusterizer clusterizer;

        public MainForm()
        {
            InitializeComponent();
            table.ForeColor = Color.Black;
            methodComboBox.SelectedIndex = 0;
            measureComboBox.SelectedIndex = 0;
            dbController = new CountrySQLiteController();
            FillTable(dbController.GetAll());
        }

        private void FillTable(List<Country> countries)
        {
            foreach(var country in countries)
            {
                table.Rows.Add(country.Name, country.ShortName, country.GDP, country.PercentInIndustry, country.PercentInAgricuture, country.PercentInServiceSphere, country.PercentOfUnemployed, country.PercentOfInflation);
            }
        }

        private void RefreshTable()
        {
            for(int i=table.Rows.Count-1; i>=0; i--)
            {
                table.Rows.RemoveAt(i);
            }
            FillTable(dbController.GetAll());
        }

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            CountryForm cf = new CountryForm();
            if(cf.ShowDialog() == DialogResult.OK)
            {
                if(dbController.GetAll().Find(x => x.Name == cf.CountryName) != null)
                {
                    MessageBox.Show("Країна з такою назвою вже є у базі даних!", "Неможливо внести дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dbController.GetAll().Find(x => x.ShortName == cf.CountryCode) != null)
                {
                    MessageBox.Show("Країна з таким кодом вже існує в базі даних!", "Неможливо внести дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dbController.Create(new Country(cf.CountryName, cf.CountryCode, cf.GDP, cf.percentInIndustry, cf.percentInAgriculture, cf.percentInServiceSphere, cf.percentOfUnemployed, cf.percentOfInflation));         
            }
            RefreshTable();
        }

        private void editCountryButton_Click(object sender, EventArgs e)
        {
            switch (table.SelectedRows.Count)
            {
                case 0:
                    MessageBox.Show("Оберіть принаймні один рядок таблиці щоб виконати дію!", "Дані не обрано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    DataGridViewCellCollection countryDataCells = table.SelectedRows[0].Cells;
                    CountryForm cf = new CountryForm(
                            countryDataCells[0].Value.ToString(),
                            countryDataCells[1].Value.ToString(),
                            (float)countryDataCells[2].Value,
                            (float)countryDataCells[3].Value,
                            (float)countryDataCells[4].Value,
                            (float)countryDataCells[5].Value,
                            (float)countryDataCells[6].Value,
                            (float)countryDataCells[7].Value
                        );
                    string countryName = countryDataCells[0].Value.ToString();
                    if (cf.ShowDialog() == DialogResult.OK)
                    {
                        if (dbController.GetAll().Find(x => x.Name == cf.CountryName && x.Name != countryName) != null)
                        {
                            MessageBox.Show("Країна з такою назвою вже є у базі даних!", "Неможливо внести дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (dbController.GetAll().Find(x => x.ShortName == cf.CountryCode && x.Name != countryName) != null)
                        {
                            MessageBox.Show("Країна з таким кодом вже існує в базі даних!", "Неможливо внести дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        dbController.Update(countryName, new Country(cf.CountryName,cf.CountryCode, cf.GDP, cf.percentInIndustry, cf.percentInAgriculture, cf.percentInServiceSphere, cf.percentOfUnemployed, cf.percentOfInflation));
                    }
                    break;
                default:
                    MessageBox.Show("Оберіть не більше одного рядка таблиці щоб виконати дію!", "Дані не обрано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            RefreshTable();
        }

        private void removeCountryButton_Click(object sender, EventArgs e)
        {
            if(table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть принаймні один рядок таблиці щоб виконати дію!", "Дані не обрано", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(MessageBox.Show("УВАГА! Всі обрані країни буде видалено із бази даних! Ви впевнені?", "Підтвердження видалення даних", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in table.SelectedRows)
                    {
                        dbController.Delete(row.Cells[0].Value.ToString());
                    }
                    RefreshTable();
                }
            }
        }

        private void clusterizationButton_Click(object sender, EventArgs e)
        {
            if((measureComboBox.SelectedIndex==4 && pField.Value==0) || (measureComboBox.SelectedIndex == 5 && (pField.Value==0 || rField.Value == 0)))
            {
                MessageBox.Show("Помилка! Для обраної міри відстані треба обов'язково вказати додаткові параметри (не нульові значення!)!", "Параметри не задані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clusterizer = CreateClusterizer();
            clusterizer.Clusterize(dbController.GetAll());
            Results.Enabled = true;
        }
        private Clusterizer CreateClusterizer()
        {
            IDistanceMeasure<Country> distanceMeasure = selectMeasure();
            IClusteringMethod clusteringMethod = selectMethod(distanceMeasure);
            Clusterizer cl = new Clusterizer(clusteringMethod);
            return cl;
        }
        private IDistanceMeasure<Country> selectMeasure()
        {
            switch (measureComboBox.SelectedIndex)
            {
                case 0: return new EuclidDistance();
                case 1: return new SquareEuclidDistance();
                case 2: return new ManhattanDistance();
                case 3: return new ChebyshevDistance();
                case 4: return new MinkovskiDistance((int)pField.Value);
                case 5: return new PowerDistance((int)pField.Value, (int)rField.Value);
                default: return null;
            }
        }
        private IClusteringMethod selectMethod(IDistanceMeasure<Country> distanceMeasure)
        {
            switch (methodComboBox.SelectedIndex)
            {
                case 0: return new NearestNeighborMethod(distanceMeasure);
                case 1: return new FarthestNeighborMethod(distanceMeasure);
                case 2: return new AverageLinkageMethod(distanceMeasure);
                case 3: return new CentroidMethod(distanceMeasure);
                case 4: return new WardMethod(distanceMeasure);
                default: return null;
            }
        }
        private void measureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(measureComboBox.SelectedIndex==4 || measureComboBox.SelectedIndex == 5)
            {
                measureParams.Enabled = true;
                measureParams.Visible = true;
            }
            else
            {
                measureParams.Enabled = false;
                measureParams.Visible = false;
            }
        }

        private void showStagesOfClustering_Click(object sender, EventArgs e)
        {
            int i = 1;
            StringBuilder strbuilder = new StringBuilder();
            strbuilder.Append("Метод об'єднання кластерів: " + clusterizer.ClusteringMethodName + "\n");
            strbuilder.Append("Міра відстаней між об'єктами: " + clusterizer.DistanceMeasureName + "\n");
            foreach (var stage in clusterizer.Stages)
            {
                strbuilder.Append(i+")  [");
                foreach(var country in stage.PairOfClusters[0].Items)
                {
                    strbuilder.Append(country.Name + ",");
                }
                strbuilder.Remove(strbuilder.Length - 1, 1);
                strbuilder.Append("] + [");
                foreach(var country in stage.PairOfClusters[1].Items)
                {
                    strbuilder.Append(country.Name + ",");
                }
                strbuilder.Remove(strbuilder.Length - 1, 1);
                strbuilder.Append("] ---> [");
                foreach(var country in stage.CombinedCluster.Items)
                {
                    strbuilder.Append(country.Name + ",");
                }
                strbuilder.Remove(strbuilder.Length - 1, 1);
                strbuilder.Append("]");
                strbuilder.Append("\n\n");
                i++;
            }
            StagesOfClusteringForm form = new StagesOfClusteringForm(strbuilder.ToString());
            form.HideElements();
            form.Show();
        }

        private void showDistanceMatrix_Click(object sender, EventArgs e)
        {
            MatrixForm form = new MatrixForm(clusterizer.GetDistanceMatrix(dbController.GetAll()), dbController.GetAll());
            form.Show();
        }

        private void showDendrogram_Click(object sender, EventArgs e)
        {
            DendrogramForm form = new DendrogramForm(clusterizer.Stages);
            form.Show();
        }

        private void showClusterTable_Click(object sender, EventArgs e)
        {
            ClusterTableForm form = new ClusterTableForm(clusterizer);
            form.FillTable();
            form.Show();
        }

        private void ShowStatistics_Click(object sender, EventArgs e)
        {
            List<Cluster> clusters = clusterizer.Clusters;
            clusters.ForEach(c => c.Items.ForEach(country => country.GDP = clusterizer.IncomingData.Find(x => x.Name == country.Name).GDP));
            StaticticsForm form = new StaticticsForm(clusters);
            form.Show();
        }
    }
}
