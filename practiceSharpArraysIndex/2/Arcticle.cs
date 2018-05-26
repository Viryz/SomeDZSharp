using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Arcticle
    {
        private readonly string name;
        private readonly string shopName;
        private readonly float cost;

        public Arcticle(string name, string shopName, int cost)
        {
            this.name = name;
            this.shopName = shopName;
            this.cost = cost;
        }

        public string Name { get { return name; } }
        public string ShopName { get { return shopName; } }
        public float Cost { get { return cost; } }
    }
}
