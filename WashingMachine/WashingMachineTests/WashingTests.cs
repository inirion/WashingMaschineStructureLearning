using NUnit.Framework;
using System.Collections.Generic;
using WashingMachine.Entities;
using WashingMachine.Entities.Cloth;
using WashingMachine.Factories;

namespace WashingMachineTests
{
    public class WashingTests
    {
        [Test]
        public void ShouldWash5Socks()
        {
            //given
            WashingMachineOperator o = new WashingMachineOperator(ClothesFactory.Create5Socks());
            List<ICloth> expected = ClothesFactory.Create5Socks();
            //when
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
