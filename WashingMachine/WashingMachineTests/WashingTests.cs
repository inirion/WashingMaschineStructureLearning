using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using WashingMachine.Entities;
using WashingMachine.Entities.Cloth;
using WashingMachine.Enums;
using WashingMachine.Factories;
using WashingMachine.Utils.Randomizer;

namespace WashingMachineTests
{
    public class WashingTests
    {
        [Test]
        public void ShouldWash5Socks()
        {
            //given
            WashingMachineOperator o = new WashingMachineOperator();
            List<ICloth> expected = ClothesFactory.Create5Socks();
            Mock<IRandomClothType> RandomClothMocked = new Mock<IRandomClothType>();
            RandomClothMocked.Setup(i => i.GetRandomClothType()).Returns(ClothType.Sock);
            //when
            for(int i = 0; i < 5; i++)
            {
                o.AddClothesToBasket(RandomClothMocked.Object);
            }
            o.OpenWashingMachine();
            o.PlaceClothesIntoWashingMachine();
            o.CloseWashingMachine();
            o.StartWashingMachine();
            o.StopWashingMachine();
            o.OpenWashingMachine();
            o.GetClothesFromWashingMachine();
            List<ICloth> result = o.GetWashedClothes();
            //than
            for(int i = 0; i < expected.Count; i++)
            {
                Assert.That(expected[i].GetType(), Is.EqualTo(result[i].GetType()));
                Assert.That(expected[i].currentState, !Is.EqualTo(result[i].currentState));
            }
            Assert.That(expected.Count, Is.EqualTo(result.Count));
        }
    }
}
