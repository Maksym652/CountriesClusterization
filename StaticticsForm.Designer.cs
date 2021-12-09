
namespace CountriesClusterization
{
    partial class StaticticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticticsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.diagramPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inflation = new System.Windows.Forms.RadioButton();
            this.unemployed = new System.Windows.Forms.RadioButton();
            this.inService = new System.Windows.Forms.RadioButton();
            this.inAgriculture = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.inIndustry = new System.Windows.Forms.RadioButton();
            this.Gdp = new System.Windows.Forms.RadioButton();
            this.countriesCount = new System.Windows.Forms.RadioButton();
            this.clusersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tablePage = new System.Windows.Forms.TabPage();
            this.fileSavingGroup = new System.Windows.Forms.GroupBox();
            this.saveToExcelBtn = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageGDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averagePercentInIndustry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averagePercentInAgriculture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averagePercentInService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averagePercentOfUnemployed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averagePercentOfInflation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.diagramPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusersChart)).BeginInit();
            this.tablePage.SuspendLayout();
            this.fileSavingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.diagramPage);
            this.tabControl1.Controls.Add(this.tablePage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // diagramPage
            // 
            this.diagramPage.Controls.Add(this.groupBox1);
            this.diagramPage.Controls.Add(this.clusersChart);
            this.diagramPage.Location = new System.Drawing.Point(4, 25);
            this.diagramPage.Name = "diagramPage";
            this.diagramPage.Padding = new System.Windows.Forms.Padding(3);
            this.diagramPage.Size = new System.Drawing.Size(826, 396);
            this.diagramPage.TabIndex = 0;
            this.diagramPage.Text = "Діаграма";
            this.diagramPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inflation);
            this.groupBox1.Controls.Add(this.unemployed);
            this.groupBox1.Controls.Add(this.inService);
            this.groupBox1.Controls.Add(this.inAgriculture);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inIndustry);
            this.groupBox1.Controls.Add(this.Gdp);
            this.groupBox1.Controls.Add(this.countriesCount);
            this.groupBox1.Location = new System.Drawing.Point(644, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 292);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Відобразити дані";
            // 
            // inflation
            // 
            this.inflation.AutoSize = true;
            this.inflation.Location = new System.Drawing.Point(6, 258);
            this.inflation.Name = "inflation";
            this.inflation.Size = new System.Drawing.Size(97, 21);
            this.inflation.TabIndex = 7;
            this.inflation.Text = "% інфляції";
            this.inflation.UseVisualStyleBackColor = true;
            this.inflation.CheckedChanged += new System.EventHandler(this.inflation_CheckedChanged);
            // 
            // unemployed
            // 
            this.unemployed.AutoSize = true;
            this.unemployed.Location = new System.Drawing.Point(34, 219);
            this.unemployed.Name = "unemployed";
            this.unemployed.Size = new System.Drawing.Size(124, 21);
            this.unemployed.TabIndex = 6;
            this.unemployed.Text = "% безробітних";
            this.unemployed.UseVisualStyleBackColor = true;
            this.unemployed.CheckedChanged += new System.EventHandler(this.unemployed_CheckedChanged);
            // 
            // inService
            // 
            this.inService.AutoSize = true;
            this.inService.Location = new System.Drawing.Point(34, 192);
            this.inService.Name = "inService";
            this.inService.Size = new System.Drawing.Size(124, 21);
            this.inService.TabIndex = 5;
            this.inService.Text = "в сфері послуг";
            this.inService.UseVisualStyleBackColor = true;
            this.inService.CheckedChanged += new System.EventHandler(this.inService_CheckedChanged);
            // 
            // inAgriculture
            // 
            this.inAgriculture.AutoSize = true;
            this.inAgriculture.Location = new System.Drawing.Point(34, 165);
            this.inAgriculture.Name = "inAgriculture";
            this.inAgriculture.Size = new System.Drawing.Size(56, 21);
            this.inAgriculture.TabIndex = 4;
            this.inAgriculture.Text = "в с/г";
            this.inAgriculture.UseVisualStyleBackColor = true;
            this.inAgriculture.CheckedChanged += new System.EventHandler(this.inAgriculture_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Середній відсоток \r\nзайнятості:";
            // 
            // inIndustry
            // 
            this.inIndustry.AutoSize = true;
            this.inIndustry.Location = new System.Drawing.Point(34, 138);
            this.inIndustry.Name = "inIndustry";
            this.inIndustry.Size = new System.Drawing.Size(136, 21);
            this.inIndustry.TabIndex = 2;
            this.inIndustry.Text = "в промисловості";
            this.inIndustry.UseVisualStyleBackColor = true;
            this.inIndustry.CheckedChanged += new System.EventHandler(this.inIndustry_CheckedChanged);
            // 
            // Gdp
            // 
            this.Gdp.AutoSize = true;
            this.Gdp.Location = new System.Drawing.Point(6, 49);
            this.Gdp.Name = "Gdp";
            this.Gdp.Size = new System.Drawing.Size(157, 38);
            this.Gdp.TabIndex = 1;
            this.Gdp.Text = "Середній ВВП \r\nна душу населення";
            this.Gdp.UseVisualStyleBackColor = true;
            this.Gdp.CheckedChanged += new System.EventHandler(this.Gdp_CheckedChanged);
            // 
            // countriesCount
            // 
            this.countriesCount.AutoSize = true;
            this.countriesCount.Checked = true;
            this.countriesCount.Location = new System.Drawing.Point(7, 22);
            this.countriesCount.Name = "countriesCount";
            this.countriesCount.Size = new System.Drawing.Size(125, 21);
            this.countriesCount.TabIndex = 0;
            this.countriesCount.TabStop = true;
            this.countriesCount.Text = "Кількість країн";
            this.countriesCount.UseVisualStyleBackColor = true;
            this.countriesCount.CheckedChanged += new System.EventHandler(this.countriesCount_CheckedChanged);
            // 
            // clusersChart
            // 
            this.clusersChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.clusersChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clusersChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.clusersChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.clusersChart.Legends.Add(legend1);
            this.clusersChart.Location = new System.Drawing.Point(7, 7);
            this.clusersChart.Name = "clusersChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.clusersChart.Series.Add(series1);
            this.clusersChart.Size = new System.Drawing.Size(807, 383);
            this.clusersChart.TabIndex = 0;
            // 
            // tablePage
            // 
            this.tablePage.Controls.Add(this.fileSavingGroup);
            this.tablePage.Controls.Add(this.dataTable);
            this.tablePage.Location = new System.Drawing.Point(4, 25);
            this.tablePage.Name = "tablePage";
            this.tablePage.Padding = new System.Windows.Forms.Padding(3);
            this.tablePage.Size = new System.Drawing.Size(826, 396);
            this.tablePage.TabIndex = 1;
            this.tablePage.Text = "Таблиця";
            this.tablePage.UseVisualStyleBackColor = true;
            // 
            // fileSavingGroup
            // 
            this.fileSavingGroup.Controls.Add(this.saveToExcelBtn);
            this.fileSavingGroup.ForeColor = System.Drawing.Color.Black;
            this.fileSavingGroup.Location = new System.Drawing.Point(7, 303);
            this.fileSavingGroup.Name = "fileSavingGroup";
            this.fileSavingGroup.Size = new System.Drawing.Size(813, 90);
            this.fileSavingGroup.TabIndex = 3;
            this.fileSavingGroup.TabStop = false;
            this.fileSavingGroup.Text = "Збереження у файл";
            // 
            // saveToExcelBtn
            // 
            this.saveToExcelBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveToExcelBtn.ForeColor = System.Drawing.Color.White;
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
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.countryCount,
            this.averageGDP,
            this.averagePercentInIndustry,
            this.averagePercentInAgriculture,
            this.averagePercentInService,
            this.averagePercentOfUnemployed,
            this.averagePercentOfInflation});
            this.dataTable.Location = new System.Drawing.Point(7, 7);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(813, 290);
            this.dataTable.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "Кластер№";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 75;
            // 
            // countryCount
            // 
            this.countryCount.HeaderText = "К-ть";
            this.countryCount.MinimumWidth = 6;
            this.countryCount.Name = "countryCount";
            this.countryCount.ReadOnly = true;
            this.countryCount.Width = 25;
            // 
            // averageGDP
            // 
            this.averageGDP.HeaderText = "ВВП на душу населення";
            this.averageGDP.MinimumWidth = 6;
            this.averageGDP.Name = "averageGDP";
            this.averageGDP.ReadOnly = true;
            this.averageGDP.Width = 80;
            // 
            // averagePercentInIndustry
            // 
            this.averagePercentInIndustry.HeaderText = "%зайнятих в пром-ті";
            this.averagePercentInIndustry.MinimumWidth = 6;
            this.averagePercentInIndustry.Name = "averagePercentInIndustry";
            this.averagePercentInIndustry.ReadOnly = true;
            this.averagePercentInIndustry.Width = 75;
            // 
            // averagePercentInAgriculture
            // 
            this.averagePercentInAgriculture.HeaderText = "%зайнятих в с/г";
            this.averagePercentInAgriculture.MinimumWidth = 6;
            this.averagePercentInAgriculture.Name = "averagePercentInAgriculture";
            this.averagePercentInAgriculture.ReadOnly = true;
            this.averagePercentInAgriculture.Width = 75;
            // 
            // averagePercentInService
            // 
            this.averagePercentInService.HeaderText = "%зайнятих в сфері послуг";
            this.averagePercentInService.MinimumWidth = 6;
            this.averagePercentInService.Name = "averagePercentInService";
            this.averagePercentInService.ReadOnly = true;
            this.averagePercentInService.Width = 75;
            // 
            // averagePercentOfUnemployed
            // 
            this.averagePercentOfUnemployed.HeaderText = "%безробітних";
            this.averagePercentOfUnemployed.MinimumWidth = 6;
            this.averagePercentOfUnemployed.Name = "averagePercentOfUnemployed";
            this.averagePercentOfUnemployed.ReadOnly = true;
            this.averagePercentOfUnemployed.Width = 75;
            // 
            // averagePercentOfInflation
            // 
            this.averagePercentOfInflation.HeaderText = "%інфляції";
            this.averagePercentOfInflation.MinimumWidth = 6;
            this.averagePercentOfInflation.Name = "averagePercentOfInflation";
            this.averagePercentOfInflation.ReadOnly = true;
            this.averagePercentOfInflation.Width = 75;
            // 
            // StaticticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "StaticticsForm";
            this.Text = "Статистика по кластерах";
            this.tabControl1.ResumeLayout(false);
            this.diagramPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusersChart)).EndInit();
            this.tablePage.ResumeLayout(false);
            this.fileSavingGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage diagramPage;
        private System.Windows.Forms.TabPage tablePage;
        private System.Windows.Forms.DataVisualization.Charting.Chart clusersChart;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.GroupBox fileSavingGroup;
        private System.Windows.Forms.Button saveToExcelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageGDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn averagePercentInIndustry;
        private System.Windows.Forms.DataGridViewTextBoxColumn averagePercentInAgriculture;
        private System.Windows.Forms.DataGridViewTextBoxColumn averagePercentInService;
        private System.Windows.Forms.DataGridViewTextBoxColumn averagePercentOfUnemployed;
        private System.Windows.Forms.DataGridViewTextBoxColumn averagePercentOfInflation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton inflation;
        private System.Windows.Forms.RadioButton unemployed;
        private System.Windows.Forms.RadioButton inService;
        private System.Windows.Forms.RadioButton inAgriculture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inIndustry;
        private System.Windows.Forms.RadioButton Gdp;
        private System.Windows.Forms.RadioButton countriesCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}