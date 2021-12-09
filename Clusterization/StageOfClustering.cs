using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    public class StageOfClustering
    {
        public float Distance { get; set; }
        public Cluster[] PairOfClusters { get; set; }
        public Cluster CombinedCluster { get; set; }

        public StageOfClustering(Cluster[] pair, Cluster combined, float distance)
        {
            PairOfClusters = pair;
            CombinedCluster = combined;
            Distance = distance;
        }
        public StageOfClustering(Cluster[] pair, Cluster combined, IClusteringMethod method)
        {
            PairOfClusters = pair;
            CombinedCluster = combined;
            Distance = method.CalculateDistance(pair[0], pair[1]);
        }

        public override string ToString()
        {
            return PairOfClusters[0].ToString()+"\t+\t"+PairOfClusters[1].ToString()+"\t--->\t"+CombinedCluster.ToString()+"\n";
        }
    }
}
