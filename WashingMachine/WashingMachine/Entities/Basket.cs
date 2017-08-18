using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WashingMachine.Entities.Cloth;

namespace WashingMachine.Entities
{
    public class Basket
    {
        private List<ICloth> clothes = new List<ICloth>();
        public void AddClothesToBasket(List<ICloth> items)
        {
            clothes.AddRange(items);
        }

        public List<ICloth> GetClothesFromBasket()
        {
            List<ICloth> temp = new List<ICloth>();
            foreach(ICloth item in clothes)
            {
                temp.Add(item);
            }
            clothes.Clear();
            return temp;
        }
    }
}
