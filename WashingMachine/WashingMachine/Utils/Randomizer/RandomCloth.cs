using System;
using WashingMachine.Enums;

namespace WashingMachine.Utils.Randomizer
{
    class RandomCloth : IRandomizer, IRandomClothType
    {
        private readonly static Random rand = new Random();

        public int RollAtRange(int min, int max)
        {
            int value = rand.Next(min, max);
            return value;
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
