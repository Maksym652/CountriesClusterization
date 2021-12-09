using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    public class Country
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public float GDP { get; set; }
        public float PercentInIndustry { get; set; }
        public float PercentInAgricuture { get; set; }
        public float PercentInServiceSphere { get; set; }
        public float PercentOfUnemployed { get; set; }
        public float PercentOfInflation { get; set; }

        public Country(string name, string shortName, float gdp, float percentInIndustry, float percentInAgricuture, float percentInServiceSphere, float percentOfUnemployed, float percentOfInflation)
        {
            Name = name;
            ShortName = shortName;
            GDP = gdp;
            PercentInIndustry = percentInIndustry;
            PercentInAgricuture = percentInAgricuture;
            PercentInServiceSphere = percentInServiceSphere;
            PercentOfUnemployed = percentOfUnemployed;
            PercentOfInflation = percentOfInflation;
        }

        public override string ToString()
        {
            return ShortName;
        }
    }
}
