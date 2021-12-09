using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class ManhattanDistance : IDistanceMeasure<Country>
    {
        public string Name => "Манхетенська відстань";

        public float CalculateDistance(Country item1, Country item2)
        {
            return Math.Abs(item1.GDP - item2.GDP) + Math.Abs(item1.PercentInIndustry - item2.PercentInIndustry) + Math.Abs(item1.PercentInAgricuture - item2.PercentInAgricuture)
                + Math.Abs(item1.PercentOfUnemployed - item2.PercentOfUnemployed) + Math.Abs(item1.PercentOfInflation - item2.PercentOfInflation);
        }
    }
}
