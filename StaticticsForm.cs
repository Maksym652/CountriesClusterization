using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesClusterization
{
    public partial class StaticticsForm : Form
    {
        Country[] allAverageValues;
        int[] counts;

        public StaticticsForm(List<Cluster> clusters)
        {
            InitializeComponent();
            Country averageValues;
            allAverageValues = new Country[clusters.Count];
            counts = new int[clusters.Count];
            clusersChart.Series.Clear();
            clusersChart.Series.Add("Кількість країн");
            for (int i=0; i<clusters.Count; i++)
            {
                //діаграма
                clusersChart.Series[0].Points.AddXY(i+1, clusters[i].Items.Count);

                //таблиця середніх значень
                averageValues = new Country("", "", 0, 0, 0, 0, 0, 0);
                foreach (var country in clusters[i].Items)
                {
                    averageValues.GDP += country.GDP;
                    averageValues.PercentInIndustry += country.PercentInIndustry;
                    averageValues.PercentInAgricuture += country.PercentInAgricuture;
                    averageValues.PercentInServiceSphere += country.PercentInServiceSphere;
                    averageValues.PercentOfUnemployed += country.PercentOfUnemployed;
                    averageValues.PercentOfInflation += country.PercentOfInflation;
                }
                averageValues.GDP /= clusters[i].Items.Count;
                averageValues.PercentInIndustry /= clusters[i].Items.Count;
                averageValues.PercentInAgricuture /= clusters[i].Items.Count;
                averageValues.PercentInServiceSphere /= clusters[i].Items.Count;
                averageValues.PercentOfUnemployed /= clusters[i].Items.Count;
                averageValues.PercentOfInflation /= clusters[i].Items.Count;
                averageValues.GDP = (float)Math.Round(averageValues.GDP, 2);
                averageValues.PercentInIndustry = (float)Math.Round(averageValues.PercentInIndustry, 2);
                averageValues.PercentInAgricuture = (float)Math.Round(averageValues.PercentInAgricuture, 2);
                averageValues.PercentInServiceSphere = (float)Math.Round(averageValues.PercentInServiceSphere, 2);
                averageValues.PercentOfUnemployed = (float)Math.Round(averageValues.PercentOfUnemployed, 2);
                averageValues.PercentOfInflation = (float)Math.Round(averageValues.PercentOfInflation, 2);

                dataTable.Rows.Add(i+1, clusters[i].Items.Count, averageValues.GDP.ToString(), averageValues.PercentInIndustry.ToString(), averageValues.PercentInAgricuture.ToString(),
                    averageValues.PercentInServiceSphere.ToString(), averageValues.PercentOfUnemployed.ToString(), averageValues.PercentOfInflation.ToString());
                dataTable.Rows[i].DefaultCellStyle.BackColor = colorsForChart[i];
                allAverageValues[i] = averageValues;
                counts[i] = clusters[i].Items.Count;
            }
        }

        private Color[] colorsForChart = new Color[]
        {
            Color.DodgerBlue,
            Color.LimeGreen,
            Color.Red,
            Color.Yellow,
            Color.Cyan,
            Color.DarkViolet,
            Color.Orange,
            Color.SkyBlue,
            Color.LightSalmon,
            Color.LightSteelBlue,
            Color.MediumSpringGreen,
            Color.Maroon,
            Color.Beige,
            Color.LightPink,
            Color.Tomato,
            Color.Khaki,
            Color.LimeGreen,
            Color.Violet,
            Color.LightGreen,
            Color.Goldenrod,
            Color.Silver,
            Color.YellowGreen,
            Color.Gold,
            Color.MediumAquamarine,
            Color.HotPink,
            Color.MediumSeaGreen,
            Color.SteelBlue,
            Color.IndianRed,
            Color.Lavender,
            Color.AliceBlue,
            Color.YellowGreen,
            Color.DarkOrange
        };

        private void countriesCount_CheckedChanged(object sender, EventArgs e)
        {
            if (countriesCount.Checked)
            {
                clusersChart.Series.Clear();
                clusersChart.Series.Add("Кількість країн");
                for(int i=0; i<counts.Length; i++)
                {
                    clusersChart.Series[0].Points.AddXY(i + 1, counts[i]);
                }
                clusersChart.ResetAutoValues();
            }
        }

        private void Gdp_CheckedChanged(object sender, EventArgs e)
        {
            if (Gdp.Checked)
            {
                clusersChart.Series.Clear();
                clusersChart.Series.Add("Середній ВВП\n на душу населення");
                for (int i = 0; i < allAverageValues.Length; i++)
                {
                    clusersChart.Series[0].Points.AddXY(i + 1, allAverageValues[i].GDP);
                }
                clusersChart.ResetAutoValues();
            }
        }

        private void inIndustry_CheckedChanged(object sender, EventArgs e)
        {
            if (inIndustry.Checked)
            {
                clusersChart.Series.Clear();
                clusersChart.Series.Add("Середній % зайнятих\n в промисловості");
                for (int i = 0; i < allAverageValues.Length; i++)
                {
                    clusersChart.Series[0].Points.AddXY(i + 1, allAverageValues[i].PercentInIndustry);
                }
                clusersChart.ResetAutoValues();
            }
        }

        private void inAgriculture_CheckedChanged(object sender, EventArgs e)
        {
            if (inAgriculture.Checked)
            {
                clusersChart.Series.Clear();
                clusersChart.Series.Add("Середній % зайнятих\n в cільському господарстві");
                for (int i = 0; i < allAverageValues.Length; i++)
                {
                    clusersChart.Series[0].Points.AddXY(i + 1, allAverageValues[i].PercentInAgricuture);
                }
                clusersChart.ResetAutoValues();
            }
        }

        private void inService_CheckedChanged(object sender, EventArgs e)
        {
            if (inService.Checked)
            {
                clusersChart.Series.Clear();
                clusersChart.Series.Add("Середній % зайнятих\n в cфері послуг");
                for (int i = 0; i < allAverageValues.Length; i++)
                {
                    clusersChart.Series[0].Points.AddXY(i + 1, allAverageValues[i].PercentInServiceSphere);
                }
                clusersChart.ResetAutoValues();
            }
        }

        private void unemployed_CheckedChanged(object sender, EventArgs e)
        {
            if (unemployed.Checked)
            {
                clusersChart.Series.Clear();
                clusersChart.Series.Add("Середній %\n безробітних");
                for (int i = 0; i < allAverageValues.Length; i++)
                {
                    clusersChart.Series[0].Points.AddXY(i + 1, allAverageValues[i].PercentOfUnemployed);
                }
                clusersChart.ResetAutoValues();
            }
        }

        private void inflation_CheckedChanged(object sender, EventArgs e)
        {
            if (inflation.Checked)
            {
                clusersChart.Series.Clear();
                clusersChart.Series.Add("Середній % інфляції");
                for (int i = 0; i < allAverageValues.Length; i++)
                {
                    clusersChart.Series[0].Points.AddXY(i + 1, allAverageValues[i].PercentOfInflation);
                }
                clusersChart.ResetAutoValues();
            }
        }

        private void saveToExcelBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                ProgressForm pf = new ProgressForm("Експорт в Excel...");
                pf.Show();
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
                Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
                for (int i = 1; i <= dataTable.ColumnCount; i++)
                {
                    worksheet.Rows[1].Columns[i] = dataTable.Columns[i - 1].HeaderText;
                }
                string str = "";
                int count = dataTable.RowCount * dataTable.ColumnCount;
                for (int i = 0; i < dataTable.RowCount - 1; i++)
                {
                    for (int j = 1; j <= dataTable.ColumnCount; j++)
                    {
                        str = dataTable.Rows[i].Cells[j - 1].Value.ToString();
                        worksheet.Rows[i + 2].Columns[j] = str;
                        pf.UpdateProgressBar((i * dataTable.ColumnCount + j) * 100 / count);
                    }
                }
                pf.UpdateProgressBar(100);
                pf.Close();
                Cursor.Current = Cursors.Arrow;
                worksheet.Columns.ColumnWidth = 5;
                workbook.SaveAs(saveFileDialog.FileName);
                excelApp.Quit();
                MessageBox.Show("Дані успішно записано у файл!", "Дію завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
