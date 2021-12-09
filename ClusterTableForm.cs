using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesClusterization
{
    public partial class ClusterTableForm : Form
    {
        Clusterizer clusterizer;
        public ClusterTableForm(Clusterizer clusterizer)
        {
            InitializeComponent();
            this.clusterizer = clusterizer;
        }

        public void FillTable()
        {
            List<Cluster> clusters = clusterizer.Clusters;
            if(clusters.Count==0)
            {
                return;
            }
            int clusterNumber = 1;
            float gdp;
            foreach(var cluster in clusters)
            {
                foreach (var country in cluster.Items)
                {
                    gdp = clusterizer.IncomingData.Find(x => x.Name == country.Name).GDP;
                    dataTable.Rows.Add(country.Name, clusterNumber, gdp, country.PercentInIndustry, country.PercentInAgricuture, country.PercentInServiceSphere, country.PercentOfUnemployed, country.PercentOfInflation);
                }
                clusterNumber++;
            }
            if (colorsForRows.Length > clusters.Count)
            {
                for (int i=0; i<dataTable.RowCount; i++)
                {
                    for(int j=0; j<dataTable.ColumnCount; j++)
                    {
                        dataTable.Rows[i].Cells[j].Style.BackColor = colorsForRows[(int)dataTable.Rows[i].Cells[1].Value-1];
                    }
                }
            }
        }

        private Color[] colorsForRows = new Color[]
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

        private void setClusterCount_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
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
                Thread.Sleep(1000);
                pf.Close();
                Cursor.Current = Cursors.Arrow;
                worksheet.Columns.ColumnWidth = 5;
                workbook.SaveAs(saveFileDialog.FileName);
                excelApp.Quit();
                MessageBox.Show("Дані успішно записано у файл!", "Дію завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveToTxtBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.WriteLine("Кластер №1:");
                for (int i = 0; i < dataTable.RowCount - 1; i++)
                {
                    sw.WriteLine(dataTable.Rows[i].Cells[0].Value.ToString());
                    if((int)dataTable.Rows[i].Cells[1].Value < (int)dataTable.Rows[i + 1].Cells[1].Value)
                    {
                        sw.WriteLine("\nКластер №" + dataTable.Rows[i + 1].Cells[1].Value.ToString()+":");
                    }
                }
                sw.Close();
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("Дані успішно записано у файл!", "Дію завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
