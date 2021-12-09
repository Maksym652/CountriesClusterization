using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class PeakDistance : IDistanceMeasure<Country>
    {
        public string Name => "Пікова відстань";

        public float CalculateDistance(Country item1, Country item2)
        {
            float result = Math.Abs(item1.GDP - item2.GDP) / (item1.GDP + item2.GDP);
            result += Math.Abs(item1.PercentInIndustry - item2.PercentInIndustry) / (item1.PercentInIndustry + item2.PercentInIndustry);
            result += Math.Abs(item1.PercentInAgricuture - item2.PercentInAgricuture) / (item1.PercentInAgricuture + item2.PercentInAgricuture);
            result += Math.Abs(item1.PercentInServiceSphere - item2.PercentInServiceSphere) / (item1.PercentInServiceSphere + item2.PercentInServiceSphere);
            result += Math.Abs(item1.PercentOfUnemployed - item2.PercentOfUnemployed) / (item1.PercentOfUnemployed + item2.PercentOfUnemployed);
            result += Math.Abs(item1.PercentOfInflation - item2.PercentOfInflation) / (item1.PercentOfInflation + item2.PercentOfInflation);
            return result / 6;
        }
    }
}
