using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class CentroidMethod : IClusteringMethod
    {
        public string Name => "Центроїдний метод";

        private IDistanceMeasure<Country> distanceMeasure;
        public IDistanceMeasure<Country> DistanceMeasure { get => distanceMeasure; set => distanceMeasure = value; }

        public CentroidMethod(IDistanceMeasure<Country> distanceMeasure)
        {
            this.distanceMeasure = distanceMeasure;
        }

        public float CalculateDistance(Cluster cl1, Cluster cl2)
        {
            Country centroid1 = GetCentroid(cl1);
            Country centroid2 = GetCentroid(cl2);
            return distanceMeasure.CalculateDistance(centroid1, centroid2);
        }
        private Country GetCentroid(Cluster cluster)
        {
            Country centroid = new Country("centroid", "c", 0, 0, 0, 0, 0, 0);
            for (int i = 0; i < cluster.Items.Count; i++)
            {
                centroid.GDP += cluster[i].GDP / cluster.Items.Count;
                centroid.PercentInIndustry += cluster[i].PercentInIndustry / cluster.Items.Count;
                centroid.PercentInAgricuture += cluster[i].PercentInAgricuture / cluster.Items.Count;
                centroid.PercentInServiceSphere += cluster[i].PercentInServiceSphere / cluster.Items.Count;
                centroid.PercentOfUnemployed += cluster[i].PercentOfUnemployed / cluster.Items.Count;
                centroid.PercentOfInflation += cluster[i].PercentOfInflation;
            }
            return centroid;
        }
    }
}
