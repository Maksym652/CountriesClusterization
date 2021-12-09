using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesClusterization
{
    public class Clusterizer
    {
        private IClusteringMethod method;

        public string DistanceMeasureName { get => method.DistanceMeasure.Name; }
        public string ClusteringMethodName { get => method.Name; }
        public List<StageOfClustering> Stages { get; }
        public List<Cluster> Clusters { get; private set; }
        public List<Country> IncomingData { get; private set; }

        public Clusterizer(IClusteringMethod clusteringMethod)
        {
            method = clusteringMethod;
            Stages = new List<StageOfClustering>();
            Clusters = new List<Cluster>();
        }

        public List<Cluster> Clusterize(List<Country> countries)
        {
            IncomingData = CloneCountryList(countries);
            Stages.Clear();
            StagesOfClusteringForm form = new StagesOfClusteringForm();
            form.Show();
            form.AddText("Метод об'єднання кластерів: " + ClusteringMethodName + "\n");
            form.AddText("Міра відстаней між об'єктами: " + DistanceMeasureName + "\n");
            form.SetText("Підготовка даних - Видалення некоректних значень...");
            List<Country> incorrect = RemoveIncorrect(countries);
            if (incorrect.Count > 0)
            {
                form.AddText("Видалення некоректних значень:");
            }
            foreach(var i in incorrect)
            {
                form.AddText(i.Name);
            }
            form.SetText("Підготовка даних - Нормалізація...");
            countries = Normalize(countries);
            List<Cluster> clusters = createClusters(countries);
            form.AddText("\nКластеризація:");
            form.SetText("Кластеризація...");
            StageOfClustering stg;
            while (clusters.Count > 1)
            {
                stg = CombinePairOfNearestClusters(clusters);
                form.AddText(stg.ToString());
                form.UpdateProgressBar((int)((countries.Count - clusters.Count)*100.0 / countries.Count));
            }
            form.UpdateProgressBar(100);
            Clusters = Clusterize();
            Clusters.Reverse();
            return clusters;
        }
        public int FindOptimalClusterCount(List<StageOfClustering> stages)
        {
            int count = stages.Count;
            float average = 0;
            for (int i = 0; i < stages.Count - 1; i++)
            {
                average += stages[i + 1].Distance - stages[i].Distance;
            }
            average /= count - 1;
            for (int i=1; i<stages.Count-1; i++)
            {
                if (stages[i + 1].Distance - stages[i].Distance > average)
                {
                    count = stages.Count - i;
                    break;
                }
            }
            return count;
        }
        public List<Cluster> Clusterize()
        {
            List<Country> countries = Stages[Stages.Count - 1].CombinedCluster.Items;
            List<Cluster> clusters = createClusters(countries);
            while (clusters.Count > FindOptimalClusterCount(Stages))
            {
                Cluster[] pairOfNearest = findNearestClusters(clusters);
                clusters.Remove(pairOfNearest[0]);
                clusters.Remove(pairOfNearest[1]);
                Cluster combined = new Cluster(pairOfNearest[0], pairOfNearest[1]);
                clusters.Add(combined);
            }
            return clusters;
        }
        private List<Cluster> createClusters(List<Country> countries)
        {
            List<Cluster> result = new List<Cluster>();
            foreach (var country in countries)
            {
                result.Add(new Cluster(country));
            }
            return result;
        }
        private Cluster[] findNearestClusters(List<Cluster> clusters)
        {
            Cluster[] pairOfNearestClusters = new Cluster[2];
            float minDistance = method.CalculateDistance(clusters[0], clusters[1]);
            foreach(Cluster cl1 in clusters)
            {
                foreach(Cluster cl2 in clusters)
                {
                    if (method.CalculateDistance(cl1, cl2) <= minDistance && cl2 != cl1)
                    {
                        pairOfNearestClusters[0] = cl1;
                        pairOfNearestClusters[1] = cl2;
                        minDistance = method.CalculateDistance(cl1, cl2);
                    }
                }
            }
            return pairOfNearestClusters;
        }
        private StageOfClustering CombinePairOfNearestClusters(List<Cluster> clusters)
        {
            Cluster[] pairOfNearest = findNearestClusters(clusters);
            clusters.Remove(pairOfNearest[0]);
            clusters.Remove(pairOfNearest[1]);
            Cluster combined = new Cluster(pairOfNearest[0], pairOfNearest[1]);
            clusters.Add(combined);
            StageOfClustering s = new StageOfClustering(pairOfNearest, combined, method);
            Stages.Add(s);
            return s;
        }
        private List<Country> Normalize(List<Country> countries)
        {
            float maxGDP = countries.Find(c => countries.All(x => c.GDP >= x.GDP)).GDP;
            float minGDP = countries.Find(c => countries.All(x => c.GDP <= x.GDP)).GDP;
            List<Country> result = new List<Country>();
            foreach(var c in countries)
            {
                result.Add(new Country(c.Name, c.ShortName, (c.GDP - minGDP)*100 / (maxGDP - minGDP), c.PercentInIndustry, c.PercentInAgricuture, c.PercentInServiceSphere, c.PercentOfUnemployed, c.PercentOfInflation));
            }
            return result;
        }
        private List<Country> RemoveIncorrect(List<Country> counries)
        {
            List<Country> incorrect = new List<Country>();
            foreach(var country in counries)
            {
                if (country.GDP < 0)
                {
                    country.Name = $"Країну [{country.Name}] видалено - ВВП країни менше 0;";
                    incorrect.Add(country);
                    continue;
                }
                if (country.PercentInIndustry < 0 || country.PercentInAgricuture < 0 || country.PercentInServiceSphere < 0 ||country.PercentOfUnemployed<0)
                {
                    country.Name = $"Країну [{country.Name}] видалено - відсоток не може бути менше 0;";
                    incorrect.Add(country);
                }
                if(country.PercentInIndustry+country.PercentInAgricuture+country.PercentInServiceSphere+country.PercentOfUnemployed<80 
                    || country.PercentInIndustry + country.PercentInAgricuture + country.PercentInServiceSphere + country.PercentOfUnemployed > 120)
                {
                    country.Name = $"Країну [{country.Name}] видалено - сумарні дані про зайнятість населення повинні бути близькими до 100%;";
                    incorrect.Add(country);
                }
            }
            counries.RemoveAll(x => incorrect.Contains(x));
            return incorrect;
        }


        public float[,] GetDistanceMatrix(List<Country> counries)
        {
            counries = Normalize(counries);
            counries = Normalize(counries);
            float[,] distanceMatrix = new float[counries.Count(), counries.Count()];
            for(int i=0; i<counries.Count; i++)
            {
                for(int j=0;j<counries.Count; j++)
                {
                    distanceMatrix[i, j] = method.DistanceMeasure.CalculateDistance(counries[i], counries[j]);
                }
            }
            return distanceMatrix;
        }
        private List<Country> CloneCountryList(List<Country> list)
        {
            List<Country> result = new List<Country>();
            foreach(var item in list)
            {
                result.Add(new Country(item.Name, item.ShortName, item.GDP, item.PercentInIndustry, item.PercentInAgricuture, item.PercentInServiceSphere, item.PercentOfUnemployed, item.PercentOfInflation));
            }
            return result;
        }
    }
}
