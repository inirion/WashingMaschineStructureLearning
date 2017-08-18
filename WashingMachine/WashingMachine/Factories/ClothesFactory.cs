using System;
using System.Collections.Generic;
using WashingMachine.Entities.Cloth;
using WashingMachine.Enums;
using WashingMachine.Utils.Randomizer;

namespace WashingMachine.Factories
{
    public class ClothesFactory
    {
        public static List<ICloth> Create5Socks()
        {
            return new List<ICloth>() {
                new Sock(),
                new Sock(),
                new Sock(),
                new Sock(),
                new Sock()
            };
        }

        public static ICloth CreateRandomCloth()
        {
            RandomCloth random = new RandomCloth();
            ClothType resault = random.GetRandomClothType();
            switch (resault)
            {
                case ClothType.Sock:
                    return new Sock();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
