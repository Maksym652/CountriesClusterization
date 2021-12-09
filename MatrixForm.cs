using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CountriesClusterization
{
    public partial class MatrixForm : Form
    {
        public MatrixForm()
        {
            InitializeComponent();
            dataTable.ForeColor = Color.Black;
        }

        public MatrixForm(float[,] matrix, List<Country> countries) : this()
        {
            this.Text = "Матриця відстаней";
            dataTable.Columns.Clear();
            DataGridViewColumn[] columns = new DataGridViewColumn[countries.Count+1];
            columns[0] = new DataGridViewTextBoxColumn();
            columns[0].HeaderText = " ";
            columns[0].Width = 50;
            for(int i=0; i<countries.Count; i++)
            {
                columns[i+1] = new DataGridViewTextBoxColumn();
                columns[i+1].HeaderText = countries[i].ShortName;
                columns[i+1].Width = 50;
                columns[i+1].SortMode = DataGridViewColumnSortMode.Automatic;
                columns[i+1].CellTemplate = new DataGridViewTextBoxCell();
            }
            dataTable.Columns.AddRange(columns);
            DataGridViewRow row;
            DataGridViewCell cell;
            for(int i = 0; i < countries.Count; i++)
            {
                row = new DataGridViewRow();
                cell = new DataGridViewTextBoxCell();
                cell.Value = countries[i];
                row.Cells.Add(cell);
                for (int j=0; j<countries.Count; j++)
                {
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = Math.Round(matrix[i, j],2);
                    row.Cells.Add(cell);
                }
                dataTable.Rows.Add(row);
            }
        }

        private void FormResized(object sender, EventArgs e)
        {
            dataTable.Size = new Size(this.Width - 50, this.Height - 175);
            fileSavingGroup.Size = new Size(this.Width - 50, 100);
            fileSavingGroup.Location = new Point(16, dataTable.Size.Height + dataTable.Location.Y + 10);
        }

        private void TableForm_MaximumSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                dataTable.Size = new Size(this.Width - 50, this.Height - 175);
            }
        }

        private void saveToExcelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені? Якщо даних багато, це займе певний час.", "Підтвердження запису у файл", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                ProgressForm pf = new ProgressForm("Експорт в Excel...");
                pf.Show();
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                for (int i = 1; i <= dataTable.ColumnCount; i++)
                {
                    worksheet.Rows[1].Columns[i] = dataTable.Columns[i - 1].HeaderText;
                }
                string str = "";
                int count = dataTable.RowCount * dataTable.ColumnCount;
                for (int i = 0; i < dataTable.RowCount-1; i++)
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
            if (MessageBox.Show("Ви впевнені? Якщо даних багато, це займе певний час.", "Підтвердження запису у файл", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            int k = 7;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < dataTable.ColumnCount; i++)
                {
                    k = 7;
                    sw.Write(dataTable.Columns[i].HeaderText.ToString());
                    while(k - dataTable.Columns[i].HeaderText.ToString().Length>0)
                    {
                        sw.Write(" ");
                        k--;
                    }
                }
                sw.WriteLine();
                int count = dataTable.RowCount * dataTable.ColumnCount;
                for (int i = 0; i < dataTable.RowCount-1; i++)
                {
                    for (int j = 0; j < dataTable.ColumnCount; j++)
                    {
                        k = 7;
                        sw.Write(dataTable.Rows[i].Cells[j].Value.ToString());
                        while (k - dataTable.Rows[i].Cells[j].Value.ToString().Length > 0)
                        {
                            sw.Write(" ");
                            k--;
                        }
                    }
                    sw.WriteLine();
                }
                Thread.Sleep(1000);
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("Дані успішно записано у файл!", "Дію завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
