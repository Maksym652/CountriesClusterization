using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class MinkovskiDistance : IDistanceMeasure<Country>
    {
        public int P { get; set; }

        public string Name => $"Відстань Мінковського {P}-ого порядку";

        public float CalculateDistance(Country item1, Country item2)
        {
            float result = PowToP(Math.Abs(item1.GDP - item2.GDP)) 
                + PowToP(Math.Abs(item1.PercentInIndustry - item2.PercentInIndustry))
                + PowToP(Math.Abs(item1.PercentInAgricuture - item2.PercentInAgricuture))
                + PowToP(Math.Abs(item1.PercentInServiceSphere - item2.PercentInServiceSphere))
                + PowToP(Math.Abs(item1.PercentOfUnemployed - item2.PercentOfUnemployed))
                + PowToP(Math.Abs(item1.PercentOfInflation - item2.PercentOfInflation));
            return (float)Math.Pow(result, 1.0 / P);
        }
        private float PowToP(float x)
        {
            return (float)Math.Pow(x, (double)P);
        }

        public MinkovskiDistance(int p)
        {
            P = p;
        }
    }
}
