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
    public partial class StagesOfClusteringForm : Form
    {
        public StagesOfClusteringForm()
        {
            InitializeComponent();
        }

        public StagesOfClusteringForm(string text)
        {
            InitializeComponent();
            textBox.Text = text;
        }

        public void HideElements()
        {
            progressBar.Visible = false;
            label1.Visible = false;
            percentLabel.Visible = false;
        }

        public void AddText(string text) 
        { 
            textBox.Text += text+"\n";
            textBox.Select(textBox.Text.LastIndexOf("\n"), 0);
            Update();
        }
        
        public void UpdateProgressBar(int i)
        {
            progressBar.Value = i;
            percentLabel.Text = i.ToString() + "%";
            if (i == 100)
            {
                label1.Text = "Кластеризацію завершено!";
            }
            Update();
        }
        public void SetText(string txt)
        {
            label1.Text = txt;
        }
    }
}
