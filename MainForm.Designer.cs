
namespace CountriesClusterization
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.table = new System.Windows.Forms.DataGridView();
            this.countryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdpPerCapita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentInIndustry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentInAgriculture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentInServiceSphere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentOfUnemployed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentOfInflation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Results = new System.Windows.Forms.GroupBox();
            this.ShowStatistics = new System.Windows.Forms.Button();
            this.showClusterTable = new System.Windows.Forms.Button();
            this.showDendrogram = new System.Windows.Forms.Button();
            this.showDistanceMatrix = new System.Windows.Forms.Button();
            this.showStagesOfClustering = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeCountryButton = new System.Windows.Forms.Button();
            this.editCountryButton = new System.Windows.Forms.Button();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.measureComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clusterizationButton = new System.Windows.Forms.Button();
            this.measureParams = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rField = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pField = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.Results.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.measureParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryName,
            this.CountryCode,
            this.gdpPerCapita,
            this.percentInIndustry,
            this.percentInAgriculture,
            this.percentInServiceSphere,
            this.percentOfUnemployed,
            this.percentOfInflation});
            this.table.Location = new System.Drawing.Point(13, 13);
            this.table.Margin = new System.Windows.Forms.Padding(4);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(752, 392);
            this.table.TabIndex = 0;
            // 
            // countryName
            // 
            this.countryName.HeaderText = "Назва країни";
            this.countryName.MinimumWidth = 6;
            this.countryName.Name = "countryName";
            this.countryName.ReadOnly = true;
            this.countryName.Width = 130;
            // 
            // CountryCode
            // 
            this.CountryCode.HeaderText = "Код";
            this.CountryCode.MinimumWidth = 6;
            this.CountryCode.Name = "CountryCode";
            this.CountryCode.ReadOnly = true;
            this.CountryCode.Width = 40;
            // 
            // gdpPerCapita
            // 
            this.gdpPerCapita.HeaderText = "ВВП на душу населення";
            this.gdpPerCapita.MinimumWidth = 6;
            this.gdpPerCapita.Name = "gdpPerCapita";
            this.gdpPerCapita.ReadOnly = true;
            this.gdpPerCapita.Width = 85;
            // 
            // percentInIndustry
            // 
            this.percentInIndustry.HeaderText = "% зайнятих у промисловості";
            this.percentInIndustry.MinimumWidth = 6;
            this.percentInIndustry.Name = "percentInIndustry";
            this.percentInIndustry.ReadOnly = true;
            this.percentInIndustry.Width = 110;
            // 
            // percentInAgriculture
            // 
            this.percentInAgriculture.HeaderText = "% зайнятих в с/г";
            this.percentInAgriculture.MinimumWidth = 6;
            this.percentInAgriculture.Name = "percentInAgriculture";
            this.percentInAgriculture.ReadOnly = true;
            this.percentInAgriculture.Width = 80;
            // 
            // percentInServiceSphere
            // 
            this.percentInServiceSphere.HeaderText = "% зайнятих в сфері послуг";
            this.percentInServiceSphere.MinimumWidth = 6;
            this.percentInServiceSphere.Name = "percentInServiceSphere";
            this.percentInServiceSphere.ReadOnly = true;
            this.percentInServiceSphere.Width = 83;
            // 
            // percentOfUnemployed
            // 
            this.percentOfUnemployed.HeaderText = "% безробітних";
            this.percentOfUnemployed.MinimumWidth = 6;
            this.percentOfUnemployed.Name = "percentOfUnemployed";
            this.percentOfUnemployed.ReadOnly = true;
            this.percentOfUnemployed.Width = 90;
            // 
            // percentOfInflation
            // 
            this.percentOfInflation.HeaderText = "% інфляції";
            this.percentOfInflation.MinimumWidth = 6;
            this.percentOfInflation.Name = "percentOfInflation";
            this.percentOfInflation.ReadOnly = true;
            this.percentOfInflation.Width = 63;
            // 
            // Results
            // 
            this.Results.Controls.Add(this.ShowStatistics);
            this.Results.Controls.Add(this.showClusterTable);
            this.Results.Controls.Add(this.showDendrogram);
            this.Results.Controls.Add(this.showDistanceMatrix);
            this.Results.Controls.Add(this.showStagesOfClustering);
            this.Results.Enabled = false;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Results.ForeColor = System.Drawing.Color.White;
            this.Results.Location = new System.Drawing.Point(215, 412);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(914, 177);
            this.Results.TabIndex = 2;
            this.Results.TabStop = false;
            this.Results.Text = "Результати";
            // 
            // ShowStatistics
            // 
            this.ShowStatistics.BackColor = System.Drawing.Color.SteelBlue;
            this.ShowStatistics.ForeColor = System.Drawing.Color.Transparent;
            this.ShowStatistics.Image = ((System.Drawing.Image)(resources.GetObject("ShowStatistics.Image")));
            this.ShowStatistics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowStatistics.Location = new System.Drawing.Point(730, 17);
            this.ShowStatistics.Name = "ShowStatistics";
            this.ShowStatistics.Size = new System.Drawing.Size(175, 154);
            this.ShowStatistics.TabIndex = 4;
            this.ShowStatistics.Text = "Статистика";
            this.ShowStatistics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ShowStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ShowStatistics.UseVisualStyleBackColor = false;
            this.ShowStatistics.Click += new System.EventHandler(this.ShowStatistics_Click);
            // 
            // showClusterTable
            // 
            this.showClusterTable.BackColor = System.Drawing.Color.SteelBlue;
            this.showClusterTable.ForeColor = System.Drawing.Color.Transparent;
            this.showClusterTable.Image = ((System.Drawing.Image)(resources.GetObject("showClusterTable.Image")));
            this.showClusterTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showClusterTable.Location = new System.Drawing.Point(549, 17);
            this.showClusterTable.Name = "showClusterTable";
            this.showClusterTable.Size = new System.Drawing.Size(175, 154);
            this.showClusterTable.TabIndex = 3;
            this.showClusterTable.Text = "Таблиця кластерів";
            this.showClusterTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showClusterTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.showClusterTable.UseVisualStyleBackColor = false;
            this.showClusterTable.Click += new System.EventHandler(this.showClusterTable_Click);
            // 
            // showDendrogram
            // 
            this.showDendrogram.BackColor = System.Drawing.Color.SteelBlue;
            this.showDendrogram.ForeColor = System.Drawing.Color.Transparent;
            this.showDendrogram.Image = ((System.Drawing.Image)(resources.GetObject("showDendrogram.Image")));
            this.showDendrogram.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showDendrogram.Location = new System.Drawing.Point(368, 17);
            this.showDendrogram.Name = "showDendrogram";
            this.showDendrogram.Size = new System.Drawing.Size(175, 154);
            this.showDendrogram.TabIndex = 2;
            this.showDendrogram.Text = "Дендрограма";
            this.showDendrogram.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showDendrogram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.showDendrogram.UseVisualStyleBackColor = false;
            this.showDendrogram.Click += new System.EventHandler(this.showDendrogram_Click);
            // 
            // showDistanceMatrix
            // 
            this.showDistanceMatrix.BackColor = System.Drawing.Color.SteelBlue;
            this.showDistanceMatrix.ForeColor = System.Drawing.Color.Transparent;
            this.showDistanceMatrix.Image = ((System.Drawing.Image)(resources.GetObject("showDistanceMatrix.Image")));
            this.showDistanceMatrix.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showDistanceMatrix.Location = new System.Drawing.Point(187, 17);
            this.showDistanceMatrix.Name = "showDistanceMatrix";
            this.showDistanceMatrix.Size = new System.Drawing.Size(175, 154);
            this.showDistanceMatrix.TabIndex = 1;
            this.showDistanceMatrix.Text = "Матриця відстаней";
            this.showDistanceMatrix.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showDistanceMatrix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.showDistanceMatrix.UseVisualStyleBackColor = false;
            this.showDistanceMatrix.Click += new System.EventHandler(this.showDistanceMatrix_Click);
            // 
            // showStagesOfClustering
            // 
            this.showStagesOfClustering.BackColor = System.Drawing.Color.SteelBlue;
            this.showStagesOfClustering.ForeColor = System.Drawing.Color.Transparent;
            this.showStagesOfClustering.Image = ((System.Drawing.Image)(resources.GetObject("showStagesOfClustering.Image")));
            this.showStagesOfClustering.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showStagesOfClustering.Location = new System.Drawing.Point(6, 17);
            this.showStagesOfClustering.Name = "showStagesOfClustering";
            this.showStagesOfClustering.Size = new System.Drawing.Size(175, 154);
            this.showStagesOfClustering.TabIndex = 0;
            this.showStagesOfClustering.Text = "Послідовність дій";
            this.showStagesOfClustering.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showStagesOfClustering.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.showStagesOfClustering.UseVisualStyleBackColor = false;
            this.showStagesOfClustering.Click += new System.EventHandler(this.showStagesOfClustering_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeCountryButton);
            this.groupBox2.Controls.Add(this.editCountryButton);
            this.groupBox2.Controls.Add(this.addCountryButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 177);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дані про країни";
            // 
            // removeCountryButton
            // 
            this.removeCountryButton.BackColor = System.Drawing.Color.SteelBlue;
            this.removeCountryButton.ForeColor = System.Drawing.Color.Transparent;
            this.removeCountryButton.Image = ((System.Drawing.Image)(resources.GetObject("removeCountryButton.Image")));
            this.removeCountryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeCountryButton.Location = new System.Drawing.Point(6, 126);
            this.removeCountryButton.Name = "removeCountryButton";
            this.removeCountryButton.Size = new System.Drawing.Size(184, 45);
            this.removeCountryButton.TabIndex = 2;
            this.removeCountryButton.Text = "Видалити";
            this.removeCountryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeCountryButton.UseVisualStyleBackColor = false;
            this.removeCountryButton.Click += new System.EventHandler(this.removeCountryButton_Click);
            // 
            // editCountryButton
            // 
            this.editCountryButton.BackColor = System.Drawing.Color.SteelBlue;
            this.editCountryButton.ForeColor = System.Drawing.Color.Transparent;
            this.editCountryButton.Image = ((System.Drawing.Image)(resources.GetObject("editCountryButton.Image")));
            this.editCountryButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.editCountryButton.Location = new System.Drawing.Point(6, 75);
            this.editCountryButton.Name = "editCountryButton";
            this.editCountryButton.Size = new System.Drawing.Size(184, 45);
            this.editCountryButton.TabIndex = 1;
            this.editCountryButton.Text = "Редагувати";
            this.editCountryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editCountryButton.UseVisualStyleBackColor = false;
            this.editCountryButton.Click += new System.EventHandler(this.editCountryButton_Click);
            // 
            // addCountryButton
            // 
            this.addCountryButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addCountryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addCountryButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.addCountryButton.FlatAppearance.BorderSize = 2;
            this.addCountryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addCountryButton.Image = ((System.Drawing.Image)(resources.GetObject("addCountryButton.Image")));
            this.addCountryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCountryButton.Location = new System.Drawing.Point(6, 24);
            this.addCountryButton.Name = "addCountryButton";
            this.addCountryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addCountryButton.Size = new System.Drawing.Size(184, 45);
            this.addCountryButton.TabIndex = 0;
            this.addCountryButton.Text = "Додати";
            this.addCountryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCountryButton.UseVisualStyleBackColor = false;
            this.addCountryButton.Click += new System.EventHandler(this.addCountryButton_Click);
            // 
            // methodComboBox
            // 
            this.methodComboBox.Items.AddRange(new object[] {
            "Метод найближчого сусіда",
            "Метод найвіддаленішого сусіда",
            "Метод міжгрупового зв\'язку",
            "Центроїдний метод",
            "Метод Уорда"});
            this.methodComboBox.Location = new System.Drawing.Point(7, 61);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(338, 30);
            this.methodComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Метод зв\'язку між кластерами:";
            // 
            // measureComboBox
            // 
            this.measureComboBox.FormattingEnabled = true;
            this.measureComboBox.Items.AddRange(new object[] {
            "Відстань Евкліда",
            "Квадрат відстані Евкліда",
            "Манхетенська відстань",
            "Відстань Чебишева",
            "Відстань Мінковського порядку p",
            "Степенева відстань"});
            this.measureComboBox.Location = new System.Drawing.Point(7, 166);
            this.measureComboBox.Name = "measureComboBox";
            this.measureComboBox.Size = new System.Drawing.Size(338, 30);
            this.measureComboBox.TabIndex = 2;
            this.measureComboBox.SelectedIndexChanged += new System.EventHandler(this.measureComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Міра відстаней між об\'єктами:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clusterizationButton);
            this.groupBox1.Controls.Add(this.measureParams);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.measureComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.methodComboBox);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(776, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(353, 399);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметри кластеризації";
            // 
            // clusterizationButton
            // 
            this.clusterizationButton.BackColor = System.Drawing.Color.SteelBlue;
            this.clusterizationButton.ForeColor = System.Drawing.Color.White;
            this.clusterizationButton.Location = new System.Drawing.Point(7, 357);
            this.clusterizationButton.Name = "clusterizationButton";
            this.clusterizationButton.Size = new System.Drawing.Size(338, 37);
            this.clusterizationButton.TabIndex = 8;
            this.clusterizationButton.Text = "Виконати кластеризацію";
            this.clusterizationButton.UseVisualStyleBackColor = false;
            this.clusterizationButton.Click += new System.EventHandler(this.clusterizationButton_Click);
            // 
            // measureParams
            // 
            this.measureParams.Controls.Add(this.label5);
            this.measureParams.Controls.Add(this.label4);
            this.measureParams.Controls.Add(this.rField);
            this.measureParams.Controls.Add(this.label3);
            this.measureParams.Controls.Add(this.pField);
            this.measureParams.Enabled = false;
            this.measureParams.ForeColor = System.Drawing.Color.White;
            this.measureParams.Location = new System.Drawing.Point(7, 236);
            this.measureParams.Name = "measureParams";
            this.measureParams.Size = new System.Drawing.Size(338, 93);
            this.measureParams.TabIndex = 7;
            this.measureParams.TabStop = false;
            this.measureParams.Text = "Додаткові параметри мір відстані";
            this.measureParams.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(166, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "(для деяких мір відстаней)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "r =";
            // 
            // rField
            // 
            this.rField.Location = new System.Drawing.Point(209, 27);
            this.rField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rField.Name = "rField";
            this.rField.Size = new System.Drawing.Size(120, 28);
            this.rField.TabIndex = 3;
            this.rField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "p =";
            // 
            // pField
            // 
            this.pField.Location = new System.Drawing.Point(40, 27);
            this.pField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pField.Name = "pField";
            this.pField.Size = new System.Drawing.Size(120, 28);
            this.pField.TabIndex = 0;
            this.pField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 17);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1141, 595);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.table);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Кластеризація країн світу за рівнем економічного розвитку";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.Results.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.measureParams.ResumeLayout(false);
            this.measureParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.GroupBox Results;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeCountryButton;
        private System.Windows.Forms.Button editCountryButton;
        private System.Windows.Forms.Button addCountryButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdpPerCapita;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentInIndustry;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentInAgriculture;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentInServiceSphere;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentOfUnemployed;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentOfInflation;
        private System.Windows.Forms.Button showStagesOfClustering;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox measureComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox measureParams;
        private System.Windows.Forms.NumericUpDown pField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown rField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clusterizationButton;
        private System.Windows.Forms.Button showDistanceMatrix;
        private System.Windows.Forms.Button showDendrogram;
        private System.Windows.Forms.Button showClusterTable;
        private System.Windows.Forms.Button ShowStatistics;
    }
}

