using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class ChebyshevDistance : IDistanceMeasure<Country>
    {
        public string Name => "Відстань Чебишева";

        public float CalculateDistance(Country item1, Country item2)
        {
            float result = Math.Abs(item1.GDP - item2.GDP);
            replaceIfGreater(ref result, Math.Abs(item1.PercentInIndustry - item2.PercentInIndustry));
            replaceIfGreater(ref result, Math.Abs(item1.PercentInAgricuture - item2.PercentInAgricuture));
            replaceIfGreater(ref result, Math.Abs(item1.PercentInServiceSphere - item2.PercentInServiceSphere));
            replaceIfGreater(ref result, Math.Abs(item1.PercentOfUnemployed - item2.PercentOfUnemployed));
            replaceIfGreater(ref result, Math.Abs(item1.PercentOfInflation - item2.PercentOfInflation));
            return result;
        }
        private void replaceIfGreater(ref float f1, float f2)
        {
            if (f2 > f1)
            {
                f1 = f2;
            }
        }
    }
}
