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

        public static ICloth CreateRandomCloth(IRandomClothType type)
        {
            ClothType resault = type.GetRandomClothType();
            switch (resault)
            {
                case ClothType.Sock:
                    return new Sock();
                case ClothType.Dress:
                    return new Dress();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
