using System;
using System.Collections.Generic;
using WashingMachine.Entities.Cloth;

namespace WashingMachine.Entities.WashingMachine
{
    public class StandardWashingMachine
    {
        public bool isOpen { get; set; }
        public bool isWashing { get; set; }
        public List<ICloth> clothes = new List<ICloth>();

        public void AddClothesToWashingMachine(List<ICloth> list)
        {
            clothes.AddRange(list);
        }

        public List<ICloth> GetClothesFromWashingMachine()
        {
            return clothes;
        }

        public void Wash()
        {
            if(!isOpen && isWashing)
            {
                foreach(ICloth item in clothes)
                {
                    item.currentState = Enums.CleanType.Clean;
                }
            }
        }
    }
}
