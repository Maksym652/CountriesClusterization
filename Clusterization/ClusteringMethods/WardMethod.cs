using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class WardMethod : IClusteringMethod
    {
        public string Name => "Метод Уорда";

        private IDistanceMeasure<Country> distanceMeasure;
        public IDistanceMeasure<Country> DistanceMeasure { get => distanceMeasure; set => distanceMeasure = value; }

        public WardMethod(IDistanceMeasure<Country> distanceMeasure)
        {
            this.distanceMeasure = distanceMeasure;
        }
        public float CalculateDistance(Cluster cl1, Cluster cl2)
        {
            CentroidMethod cm = new CentroidMethod(distanceMeasure);
            float distance = cm.CalculateDistance(cl1, cl2);
            distance *= distance;
            distance *= (cl1.Items.Count * cl2.Items.Count) / (cl1.Items.Count + cl2.Items.Count);
            return distance;
        }
    }
}
