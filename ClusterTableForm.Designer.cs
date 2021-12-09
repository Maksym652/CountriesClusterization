
namespace CountriesClusterization
{
    partial class ClusterTableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClusterTableForm));
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClusterNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentInIndustry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentInAgriculture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentInService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentOfUnemployed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentOfInflation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveToTxtBtn = new System.Windows.Forms.Button();
            this.saveToExcelBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.ClusterNum,
            this.GDP,
            this.percentInIndustry,
            this.percentInAgriculture,
            this.percentInService,
            this.percentOfUnemployed,
            this.percentOfInflation});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.Location = new System.Drawing.Point(12, 8);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(830, 353);
            this.dataTable.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Назва країни";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // ClusterNum
            // 
            this.ClusterNum.HeaderText = "Кластер №";
            this.ClusterNum.MinimumWidth = 6;
            this.ClusterNum.Name = "ClusterNum";
            this.ClusterNum.ReadOnly = true;
            this.ClusterNum.Width = 55;
            // 
            // GDP
            // 
            this.GDP.HeaderText = "ВВП на душу населення";
            this.GDP.MinimumWidth = 6;
            this.GDP.Name = "GDP";
            this.GDP.ReadOnly = true;
            this.GDP.Width = 70;
            // 
            // percentInIndustry
            // 
            this.percentInIndustry.HeaderText = "% зайнятих у пром-ті";
            this.percentInIndustry.MinimumWidth = 6;
            this.percentInIndustry.Name = "percentInIndustry";
            this.percentInIndustry.ReadOnly = true;
            this.percentInIndustry.Width = 60;
            // 
            // percentInAgriculture
            // 
            this.percentInAgriculture.HeaderText = "% зайнятих у с/г";
            this.percentInAgriculture.MinimumWidth = 6;
            this.percentInAgriculture.Name = "percentInAgriculture";
            this.percentInAgriculture.ReadOnly = true;
            this.percentInAgriculture.Width = 60;
            // 
            // percentInService
            // 
            this.percentInService.HeaderText = "% зайнятих в сфері послуг";
            this.percentInService.MinimumWidth = 6;
            this.percentInService.Name = "percentInService";
            this.percentInService.ReadOnly = true;
            this.percentInService.Width = 60;
            // 
            // percentOfUnemployed
            // 
            this.percentOfUnemployed.HeaderText = "%безробітних";
            this.percentOfUnemployed.MinimumWidth = 6;
            this.percentOfUnemployed.Name = "percentOfUnemployed";
            this.percentOfUnemployed.ReadOnly = true;
            this.percentOfUnemployed.Width = 60;
            // 
            // percentOfInflation
            // 
            this.percentOfInflation.HeaderText = "% інфляції";
            this.percentOfInflation.MinimumWidth = 6;
            this.percentOfInflation.Name = "percentOfInflation";
            this.percentOfInflation.ReadOnly = true;
            this.percentOfInflation.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveToTxtBtn);
            this.groupBox1.Controls.Add(this.saveToExcelBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Зберегти в файл";
            // 
            // saveToTxtBtn
            // 
            this.saveToTxtBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveToTxtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveToTxtBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveToTxtBtn.Image")));
            this.saveToTxtBtn.Location = new System.Drawing.Point(215, 23);
            this.saveToTxtBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveToTxtBtn.Name = "saveToTxtBtn";
            this.saveToTxtBtn.Size = new System.Drawing.Size(224, 50);
            this.saveToTxtBtn.TabIndex = 4;
            this.saveToTxtBtn.Text = "Зберегти в текстовий файл";
            this.saveToTxtBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveToTxtBtn.UseVisualStyleBackColor = false;
            this.saveToTxtBtn.Click += new System.EventHandler(this.saveToTxtBtn_Click);
            // 
            // saveToExcelBtn
            // 
            this.saveToExcelBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveToExcelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveToExcelBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveToExcelBtn.Image")));
            this.saveToExcelBtn.Location = new System.Drawing.Point(7, 23);
            this.saveToExcelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveToExcelBtn.Name = "saveToExcelBtn";
            this.saveToExcelBtn.Size = new System.Drawing.Size(207, 50);
            this.saveToExcelBtn.TabIndex = 3;
            this.saveToExcelBtn.Text = "Зберегти в Excel";
            this.saveToExcelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveToExcelBtn.UseVisualStyleBackColor = false;
            this.saveToExcelBtn.Click += new System.EventHandler(this.saveToExcelBtn_Click);
            // 
            // ClusterTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataTable);
            this.Name = "ClusterTableForm";
            this.Text = "Розподіл по кластерам";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveToTxtBtn;
        private System.Windows.Forms.Button saveToExcelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClusterNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentInIndustry;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentInAgriculture;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentInService;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentOfUnemployed;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentOfInflation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}