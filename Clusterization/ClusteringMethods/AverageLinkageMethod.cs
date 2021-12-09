using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    class AverageLinkageMethod : IClusteringMethod
    {
        public string Name => "Метод середнього (міжгрупового) зв'язку";

        private IDistanceMeasure<Country> distanceMeasure;
        public IDistanceMeasure<Country> DistanceMeasure { get => distanceMeasure; set => distanceMeasure=value; }

        public AverageLinkageMethod(IDistanceMeasure<Country> distanceMeasure)
        {
            this.distanceMeasure = distanceMeasure;
        }

        public float CalculateDistance(Cluster cl1, Cluster cl2)
        {
            float distance = 0;
            int pairsCount = cl1.Items.Count * cl2.Items.Count;
            for (int i = 0; i < cl1.Items.Count; i++)
            {
                for (int j = 0; j < cl2.Items.Count; j++)
                {
                      distance += distanceMeasure.CalculateDistance(cl1[i], cl2[j]) / pairsCount;
                }
            }
            return distance;
        }
    }
}
