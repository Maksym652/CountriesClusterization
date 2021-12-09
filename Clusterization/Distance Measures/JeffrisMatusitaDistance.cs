using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class JeffrisMatusitaDistance : IDistanceMeasure<Country>
    {
        public string Name => "Відстань Джеффріса-Матусіти";

        public float CalculateDistance(Country item1, Country item2)
        {
            double result = Math.Pow(Math.Sqrt(item1.GDP) - Math.Sqrt(item2.GDP), 2);
            result += Math.Pow(Math.Sqrt(item1.PercentInIndustry) - Math.Sqrt(item2.PercentInIndustry), 2);
            result += Math.Pow(Math.Sqrt(item1.PercentInAgricuture) - Math.Sqrt(item2.PercentInAgricuture), 2);
            result += Math.Pow(Math.Sqrt(item1.PercentInServiceSphere) - Math.Sqrt(item2.PercentInServiceSphere), 2);
            result += Math.Pow(Math.Sqrt(item1.PercentOfInflation) - Math.Sqrt(item2.PercentOfInflation), 2);
            result += Math.Pow(Math.Sqrt(item1.PercentOfUnemployed) - Math.Sqrt(item2.PercentOfUnemployed), 2);
            return (float)Math.Sqrt(result);
        }
    }
}
