
namespace CountriesClusterization
{
    partial class MatrixForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixForm));
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.saveToExcelBtn = new System.Windows.Forms.Button();
            this.fileSavingGroup = new System.Windows.Forms.GroupBox();
            this.saveToTxtBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.fileSavingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(16, 15);
            this.dataTable.Margin = new System.Windows.Forms.Padding(4);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(1066, 465);
            this.dataTable.TabIndex = 0;
            // 
            // saveToExcelBtn
            // 
            this.saveToExcelBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveToExcelBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveToExcelBtn.Image")));
            this.saveToExcelBtn.Location = new System.Drawing.Point(7, 27);
            this.saveToExcelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveToExcelBtn.Name = "saveToExcelBtn";
            this.saveToExcelBtn.Size = new System.Drawing.Size(224, 51);
            this.saveToExcelBtn.TabIndex = 1;
            this.saveToExcelBtn.Text = "Зберегти в Excel";
            this.saveToExcelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveToExcelBtn.UseVisualStyleBackColor = false;
            this.saveToExcelBtn.Click += new System.EventHandler(this.saveToExcelBtn_Click);
            // 
            // fileSavingGroup
            // 
            this.fileSavingGroup.Controls.Add(this.saveToTxtBtn);
            this.fileSavingGroup.Controls.Add(this.saveToExcelBtn);
            this.fileSavingGroup.ForeColor = System.Drawing.Color.White;
            this.fileSavingGroup.Location = new System.Drawing.Point(16, 488);
            this.fileSavingGroup.Name = "fileSavingGroup";
            this.fileSavingGroup.Size = new System.Drawing.Size(1066, 100);
            this.fileSavingGroup.TabIndex = 2;
            this.fileSavingGroup.TabStop = false;
            this.fileSavingGroup.Text = "Збереження у файл";
            // 
            // saveToTxtBtn
            // 
            this.saveToTxtBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveToTxtBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveToTxtBtn.Image")));
            this.saveToTxtBtn.Location = new System.Drawing.Point(276, 27);
            this.saveToTxtBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveToTxtBtn.Name = "saveToTxtBtn";
            this.saveToTxtBtn.Size = new System.Drawing.Size(224, 51);
            this.saveToTxtBtn.TabIndex = 2;
            this.saveToTxtBtn.Text = "Зберегти в текстовий файл";
            this.saveToTxtBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveToTxtBtn.UseVisualStyleBackColor = false;
            this.saveToTxtBtn.Click += new System.EventHandler(this.saveToTxtBtn_Click);
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1100, 591);
            this.Controls.Add(this.fileSavingGroup);
            this.Controls.Add(this.dataTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatrixForm";
            this.Text = "Матриця відстаней";
            this.MaximumSizeChanged += new System.EventHandler(this.TableForm_MaximumSizeChanged);
            this.Resize += new System.EventHandler(this.FormResized);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.fileSavingGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button saveToExcelBtn;
        private System.Windows.Forms.GroupBox fileSavingGroup;
        private System.Windows.Forms.Button saveToTxtBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}