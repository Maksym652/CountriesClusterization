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
    public partial class CountryForm : Form
    {
        public string CountryName { get => nameField.Text; }
        public string CountryCode { get => countryCode.Text; }
        public float GDP { get => (float)gdpField.Value; }
        public float percentInIndustry { get => (float)industryField.Value; }
        public float percentInAgriculture { get => (float)agricultureField.Value; }
        public float percentInServiceSphere { get => (float)serviceSphereField.Value; }
        public float percentOfUnemployed { get => (float)unemployedField.Value; }
        public float percentOfInflation { get => (float)inflationField.Value; }

        public CountryForm()
        {
            InitializeComponent();
        }
        public CountryForm(string name, string code, float gdp, float industry, float agriculture, float service, float unemployed, float inflation)
        {
            InitializeComponent();
            nameField.Text = name;
            countryCode.Text = code;
            gdpField.Value = (decimal)gdp;
            industryField.Value = (decimal)industry;
            agricultureField.Value = (decimal)agriculture;
            serviceSphereField.Value = (decimal)service;
            unemployedField.Value = (decimal)unemployed;
            inflationField.Value = (decimal)inflation;
        }
    }
}
