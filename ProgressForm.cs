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
    public partial class ProgressForm : Form
    {
        public ProgressForm(string txt)
        {
            InitializeComponent();
            this.Text = txt;
            label2.Text = "0%";
        }

        public void UpdateProgressBar(int i)
        {
            progressBar1.Value = i;
            label2.Text = i.ToString() + "%";
            Update();
        }
    }
}
