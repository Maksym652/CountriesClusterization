using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class CosineDistance : IDistanceMeasure<Country>
    {
        public string Name => "Відстань косинус";

        public float CalculateDistance(Country item1, Country item2)
        {
            float sum1 = item1.GDP * item2.GDP;
            sum1 += item1.PercentInIndustry * item2.PercentInIndustry;
            sum1 += item1.PercentInAgricuture * item2.PercentInAgricuture;
            sum1 += item1.PercentInServiceSphere * item2.PercentInServiceSphere;
            sum1 += item1.PercentOfUnemployed * item2.PercentOfUnemployed;
            sum1 += item1.PercentOfInflation * item2.PercentOfInflation;
            float sum2 = item1.GDP*item1.GDP;
            sum2 += item1.PercentInIndustry * item1.PercentInIndustry;
            sum2 += item1.PercentInAgricuture * item1.PercentInAgricuture;
            sum2 += item1.PercentInServiceSphere * item1.PercentInServiceSphere;
            sum2 += item1.PercentOfUnemployed * item1.PercentOfUnemployed;
            sum2 += item1.PercentOfInflation * item1.PercentOfInflation;
            float sum3 = item2.GDP * item2.GDP;
            sum3 += item2.PercentInIndustry * item2.PercentInIndustry;
            sum3 += item2.PercentInAgricuture * item2.PercentInAgricuture;
            sum3 += item2.PercentInServiceSphere * item2.PercentInServiceSphere;
            sum3 += item2.PercentOfUnemployed * item2.PercentOfUnemployed;
            sum3 += item2.PercentOfInflation * item2.PercentOfInflation;
            return (float)(1 - sum1 / (Math.Sqrt(sum2) * Math.Sqrt(sum2)));
        }
    }
}
