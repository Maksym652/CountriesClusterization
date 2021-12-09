using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    public interface IClusteringMethod
    {
        string Name { get; }
        IDistanceMeasure<Country> DistanceMeasure { get; set; }
        float CalculateDistance(Cluster cl1, Cluster cl2);
    }
}
