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
            ///<summary>
            ///WashingMachineOperator is orchestrator pattern invoking all actions of main entities
            ///Good Sequence for WashingMachine usage are fallowing:
            ///->Place clothes in basket
            ///->Open WashingMachine
            ///->Place clothes inside WashingMachine
            ///->Close WashingMachine
            ///->Start WashingMachine
            ///Now optional steps to add to washing machine while others clothes are washed
            ///     ->Place clothes in basket
            ///     ->Stop WashingMachine
            ///     ->Open WashingMachine
            ///     ->Place clothes inside WashingMachine
            ///     ->Close WashingMachine
            ///     ->Start WashingMachine
            ///And rest follow like this
            ///->Stop WashingMachine
            ///->Open WashingMachine
            ///->Get clothes from WashingMachine
            ///
            /// And helper method to get List of cloths to display it Get Washed Clothes
            /// 
            /// If you skip one step nothing will happen for example
            /// -->You can't place clothes form basket to WashingMachine if door are closed and WashingMachine is running =)
            /// -->u can't get washed cloths from WashingMachine if door are closed and WashingMachine is running =)
            /// -->etc. just like in real life
            ///</summary>
            WashingMachineOperator o = new WashingMachineOperator();
            o.AddClothesToBasket();
            o.OpenWashingMachine();
            o.PlaceClothesIntoWashingMachine();
            o.CloseWashingMachine();
            o.StartWashingMachine();
            o.AddClothesToBasket();
            o.StopWashingMachine();
            o.OpenWashingMachine();
            o.PlaceClothesIntoWashingMachine();
            o.CloseWashingMachine();
            o.StartWashingMachine();
            o.StopWashingMachine();
            o.OpenWashingMachine();
            o.GetClothesFromWashingMachine();
            foreach (ICloth item in o.GetWashedClothes())
            {
                Console.WriteLine(item.GetType().ToString() + " " + item.currentState.ToString());
            }
        }
    }
}
