using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class NearestNeighborMethod : IClusteringMethod
    {
        public string Name => "Метод найближчого сусіда";

        private IDistanceMeasure<Country> distanceMeasure;
        public IDistanceMeasure<Country> DistanceMeasure { get => distanceMeasure; set => this.distanceMeasure = value; }

        public NearestNeighborMethod(IDistanceMeasure<Country> distanceMeasure)
        {
            this.distanceMeasure = distanceMeasure;
        }

        public float CalculateDistance(Cluster cl1, Cluster cl2)
        {
            float distance = distanceMeasure.CalculateDistance(cl1[0], cl2[0]);
            for(int i=0; i<cl1.Items.Count; i++)
            {
                for(int j=0; j<cl2.Items.Count; j++)
                {
                    if (distance > distanceMeasure.CalculateDistance(cl1[0], cl2[0]))
                    {
                        distance = distanceMeasure.CalculateDistance(cl1[0], cl2[0]);
                    }
                }
            }
            return distance;
        }
    }
}
