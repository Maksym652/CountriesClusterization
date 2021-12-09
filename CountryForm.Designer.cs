
namespace CountriesClusterization
{
    partial class CountryForm
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gdpField = new System.Windows.Forms.NumericUpDown();
            this.industryField = new System.Windows.Forms.NumericUpDown();
            this.agricultureField = new System.Windows.Forms.NumericUpDown();
            this.serviceSphereField = new System.Windows.Forms.NumericUpDown();
            this.unemployedField = new System.Windows.Forms.NumericUpDown();
            this.inflationField = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.countryCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdpField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industryField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agricultureField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceSphereField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unemployedField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inflationField)).BeginInit();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(96, 6);
            this.nameField.Margin = new System.Windows.Forms.Padding(4);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(356, 27);
            this.nameField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ВВП на душу населення:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Відсоток зайнятих у промисловості:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Відсоток зайнятих у сільському господарстві:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Відсоток зайнятих у сфері послуг:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Відсоток безробітних:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Відсоток інфляції:";
            // 
            // gdpField
            // 
            this.gdpField.DecimalPlaces = 2;
            this.gdpField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.gdpField.Location = new System.Drawing.Point(473, 37);
            this.gdpField.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.gdpField.Name = "gdpField";
            this.gdpField.Size = new System.Drawing.Size(132, 27);
            this.gdpField.TabIndex = 8;
            // 
            // industryField
            // 
            this.industryField.DecimalPlaces = 2;
            this.industryField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.industryField.Location = new System.Drawing.Point(473, 74);
            this.industryField.Name = "industryField";
            this.industryField.Size = new System.Drawing.Size(132, 27);
            this.industryField.TabIndex = 9;
            // 
            // agricultureField
            // 
            this.agricultureField.DecimalPlaces = 2;
            this.agricultureField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.agricultureField.Location = new System.Drawing.Point(472, 112);
            this.agricultureField.Name = "agricultureField";
            this.agricultureField.Size = new System.Drawing.Size(132, 27);
            this.agricultureField.TabIndex = 10;
            // 
            // serviceSphereField
            // 
            this.serviceSphereField.DecimalPlaces = 2;
            this.serviceSphereField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.serviceSphereField.Location = new System.Drawing.Point(473, 150);
            this.serviceSphereField.Name = "serviceSphereField";
            this.serviceSphereField.Size = new System.Drawing.Size(132, 27);
            this.serviceSphereField.TabIndex = 11;
            // 
            // unemployedField
            // 
            this.unemployedField.DecimalPlaces = 2;
            this.unemployedField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.unemployedField.Location = new System.Drawing.Point(472, 186);
            this.unemployedField.Name = "unemployedField";
            this.unemployedField.Size = new System.Drawing.Size(132, 27);
            this.unemployedField.TabIndex = 12;
            // 
            // inflationField
            // 
            this.inflationField.DecimalPlaces = 2;
            this.inflationField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inflationField.Location = new System.Drawing.Point(472, 221);
            this.inflationField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inflationField.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.inflationField.Name = "inflationField";
            this.inflationField.Size = new System.Drawing.Size(132, 27);
            this.inflationField.TabIndex = 13;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.SteelBlue;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(318, 254);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(206, 34);
            this.okButton.TabIndex = 14;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(78, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Скасувати";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Код:";
            // 
            // countryCode
            // 
            this.countryCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.countryCode.Location = new System.Drawing.Point(521, 6);
            this.countryCode.Margin = new System.Windows.Forms.Padding(4);
            this.countryCode.Name = "countryCode";
            this.countryCode.Size = new System.Drawing.Size(83, 27);
            this.countryCode.TabIndex = 17;
            // 
            // CountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(618, 296);
            this.Controls.Add(this.countryCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.inflationField);
            this.Controls.Add(this.unemployedField);
            this.Controls.Add(this.serviceSphereField);
            this.Controls.Add(this.agricultureField);
            this.Controls.Add(this.industryField);
            this.Controls.Add(this.gdpField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CountryForm";
            this.Text = "Дані про країну";
            ((System.ComponentModel.ISupportInitialize)(this.gdpField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industryField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agricultureField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceSphereField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unemployedField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inflationField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.NumericUpDown gdpField;
        private System.Windows.Forms.NumericUpDown industryField;
        private System.Windows.Forms.NumericUpDown agricultureField;
        private System.Windows.Forms.NumericUpDown serviceSphereField;
        private System.Windows.Forms.NumericUpDown unemployedField;
        private System.Windows.Forms.NumericUpDown inflationField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox countryCode;
    }
}