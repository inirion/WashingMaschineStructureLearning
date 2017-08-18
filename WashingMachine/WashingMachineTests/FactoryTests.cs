using NUnit.Framework;
using System.Collections.Generic;
using WashingMachine.Entities.Cloth;
using WashingMachine.Factories;
using Moq;
using WashingMachine.Utils.Randomizer;
using WashingMachine.Enums;

namespace WashingMachineTests
{
    public class FactoryTests
    {
        [Test]
        public void ShouldGetSockAsRandomItemFromClothFactory()
        {
            //given 
            ICloth expected = new Sock();
            Mock<IRandomClothType> RandomClothMocked = new Mock<IRandomClothType>();
            RandomClothMocked.Setup(i => i.GetRandomClothType()).Returns(ClothType.Sock);

            //when
            ICloth resault = ClothesFactory.CreateRandomCloth(RandomClothMocked.Object);
            //than
            Assert.AreEqual(expected.GetType(), resault.GetType());
        }

        [Test]
        public void ShouldProduce5SocksInClothFactory()
        {
            //given 
            List<ICloth> expected = new List<ICloth>()
            {
                new Sock(),
                new Sock(),
                new Sock(),
                new Sock(),
                new Sock()
            };
            //when
            List<ICloth> resault = ClothesFactory.Create5Socks();
            //than
            for(int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].GetType(), resault[i].GetType());
            }
            
        }

    }
}
