using System;
using WashingMachine.Entities;
using WashingMachine.Entities.Cloth;
using WashingMachine.Factories;

namespace WashingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            WashingMachineOperator o = new WashingMachineOperator(ClothesFactory.Create5Socks());
            o.OpenWashingMachine();
            o.PlaceClothesIntoWashingMachine();
            o.CloseWashingMachine();
            o.StartWashingMachine();
            o.StopWashingMachine();
            o.OpenWashingMachine();
            o.GetClothesFromWashingMachine();
            foreach (ICloth item in o.GetWashedClothes())
            {
                Console.WriteLine(item.currentState.ToString());
            }
        }
    }
}
