using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WashingMachine.Enums;

namespace WashingMachine.Utils.Randomizer
{
    class RandomCloth : IRandomizer
    {
        Random rand = new Random();
        public int RollAtRange(int min, int max)
        {
            return rand.Next(min,max);
        }

        public ClothType GetRandomClothType()
        {
            int minRange = 0;
            int maxRange = Enum.GetNames(typeof(ClothType)).Length;
            int resault = RollAtRange(minRange, maxRange);
            return (ClothType)resault;
        }
    }
}
