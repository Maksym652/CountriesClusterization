using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesClusterization
{
    public class Cluster
    {
        private List<Country> items;
        public List<Country> Items { get => items; }
        public void Add(Country item)
        {
            items.Add(item);
        }
        public void Remove(Country item) 
        { 
            items.Remove(item); 
        }
        public Country this[int i]
        {
            get => items[i];
            set => items[i] = value;
        }

        public Cluster(Country country)
        {
            items = new List<Country>();
            items.Add(country);
        }
        public Cluster(List<Country> countries)
        {
            items = countries;
        }
        public Cluster(Cluster cl1, Cluster cl2)
        {
            items = new List<Country>();
            items.AddRange(cl1.Items);
            items.AddRange(cl2.Items);
        }

        public override string ToString()
        {
            switch (items.Count)
            {
                case 0: return "emptyCluster";
                case 1: return items[0].ToString();
                case 2: return items[0].ToString() + "," + items[1].ToString();
                case 3: return items[0].ToString() + "," + items[1].ToString() + "," + items[2].ToString();
                case 4: return items[0].ToString() + "," + items[1].ToString() + "," + items[2].ToString() + "," + items[3].ToString();
                default: return "["+items[0].ToString() + "-" + items[items.Count - 1].ToString()+"]"+$"({items.Count})";
            }
        }
    }
}
