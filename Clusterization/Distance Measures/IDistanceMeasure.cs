using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    public interface IDistanceMeasure<T>
    {
        string Name { get; }
        float CalculateDistance(T item1, T item2);
    }
}
