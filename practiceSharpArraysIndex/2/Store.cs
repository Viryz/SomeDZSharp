using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Store
    {
        private Arcticle[] array;

        public Store()
        {
            array = new Arcticle[]
            {
                new Arcticle("Tea", "Cafe", 14),
                new Arcticle("Ball", "SportShop", 50),
                new Arcticle("Dress", "WoomenShop", 3000)
            };
        }

        public Arcticle this[int index]
        {
            get
            {
                return array[index];
            }
        }

        public Arcticle this[string name]
        {
            get
            {
                Arcticle tmp = array.FirstOrDefault((item) =>
                {
                    if (item.Name == name)
                        return true;
                    else return false;
                });

                if (tmp != null)
                    return tmp;
                else throw new Exception(string.Format("This arcticle ({0}) not found", name));
            }
        }

     }

}

