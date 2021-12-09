using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class CorelationDistance : IDistanceMeasure<Country>
    {
        public string Name => "Відстань кореляції";

        public float CalculateDistance(Country item1, Country item2)
        {
            float sum1 = (item1.GDP - (item1.GDP + item2.GDP) / 2) * (item2.GDP - (item1.GDP + item2.GDP) / 2);
            sum1 += (item1.PercentInIndustry - (item1.PercentInIndustry + item2.PercentInIndustry) / 2) * (item2.PercentInIndustry - (item1.PercentInIndustry + item2.PercentInIndustry) / 2);
            sum1 += (item1.PercentInAgricuture - (item1.PercentInAgricuture + item2.PercentInAgricuture) / 2) * (item2.PercentInAgricuture - (item1.PercentInAgricuture + item2.PercentInAgricuture) / 2);
            sum1 += (item1.PercentInServiceSphere - (item1.PercentInServiceSphere + item2.PercentInServiceSphere) / 2) * (item2.PercentInServiceSphere - (item1.PercentInServiceSphere + item2.PercentInServiceSphere) / 2);
            sum1 += (item1.PercentOfUnemployed - (item1.PercentOfUnemployed + item2.PercentOfUnemployed) / 2) * (item2.PercentOfUnemployed - (item1.PercentOfUnemployed + item2.PercentOfUnemployed) / 2);
            sum1 += (item1.PercentOfInflation - (item1.PercentOfInflation + item2.PercentOfInflation) / 2) * (item2.PercentOfInflation - (item1.PercentOfInflation + item2.PercentOfInflation) / 2);
            float sum2 = (item1.GDP - (item1.GDP + item2.GDP) / 2);
            sum2 += (item1.PercentInIndustry - (item1.PercentInIndustry + item2.PercentInIndustry) / 2);
            sum2 += (item1.PercentInAgricuture - (item1.PercentInAgricuture + item2.PercentInAgricuture) / 2);
            sum2 += (item1.PercentInServiceSphere - (item1.PercentInServiceSphere + item2.PercentInServiceSphere) / 2);
            sum2 += (item1.PercentOfUnemployed - (item1.PercentOfUnemployed + item2.PercentOfUnemployed) / 2);
            sum2 += (item1.PercentOfInflation - (item1.PercentOfInflation + item2.PercentOfInflation) / 2);
            float sum3 = (item2.GDP - (item1.GDP + item2.GDP) / 2);
            sum3 += (item2.PercentInIndustry - (item1.PercentInIndustry + item2.PercentInIndustry) / 2);
            sum3 += (item2.PercentInAgricuture - (item1.PercentInAgricuture + item2.PercentInAgricuture) / 2);
            sum3 += (item2.PercentInServiceSphere - (item1.PercentInServiceSphere + item2.PercentInServiceSphere) / 2);
            sum3 += (item2.PercentOfUnemployed - (item1.PercentOfUnemployed + item2.PercentOfUnemployed) / 2);
            sum3 += (item2.PercentOfInflation - (item1.PercentOfInflation + item2.PercentOfInflation) / 2);
            return (float)(1 - sum1 / (Math.Sqrt(sum2) * Math.Sqrt(sum3)));
        }
    }
}
