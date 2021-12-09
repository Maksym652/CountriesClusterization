using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class EuclidDistance : IDistanceMeasure<Country>
    {
        public string Name => "Відстань Евкліда";

        public float CalculateDistance(Country item1, Country item2)
        {
            double result = Pow2(item1.GDP - item2.GDP)
                + Pow2(item1.PercentInIndustry - item2.PercentInIndustry)
                + Pow2(item1.PercentInAgricuture - item2.PercentInAgricuture)
                + Pow2(item1.PercentInServiceSphere - item2.PercentInServiceSphere)
                + Pow2(item1.PercentOfUnemployed - item2.PercentOfUnemployed)
                + Pow2(item1.PercentOfInflation - item2.PercentOfInflation);
            return (float)Math.Sqrt(result);
        }

        private double Pow2(double x) => x * x;
    }
}
