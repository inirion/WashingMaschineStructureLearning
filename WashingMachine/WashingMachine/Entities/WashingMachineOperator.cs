﻿using System;
using System.Collections.Generic;
using WashingMachine.Entities.Cloth;
using WashingMachine.Entities.WashingMachine;
using WashingMachine.Factories;

namespace WashingMachine.Entities
{
    public class WashingMachineOperator
    {
        private Basket basket;
        private StandardWashingMachine washingMachine;
        private List<ICloth> washedCloths = new List<ICloth>();

        public WashingMachineOperator(List<ICloth> clothes)
        {
            basket = new Basket();
            basket.AddClothesToBasket(clothes);
            washingMachine = new StandardWashingMachine();
        }

        public List<ICloth> GetWashedClothes()
        {
            return washedCloths;
        }

        public void PlaceClothesIntoWashingMachine()
        {
            if(washingMachine.isOpen == true)
            {
                washingMachine.AddClothesToWashingMachine(basket.GetClothesFromBasket());
            }
        }

        public void GetClothesFromWashingMachine()
        {
            if (washingMachine.isOpen == true && !washingMachine.isWashing)
            {
                washedCloths = washingMachine.GetClothesFromWashingMachine();
            }
        }

        public void StartWashingMachine()
        {
            if (!washingMachine.isOpen)
            {
                washingMachine.isWashing = true;
                washingMachine.Wash();
            }
        }

        public void StopWashingMachine()
        {
            if (!washingMachine.isOpen)
            {
                washingMachine.isWashing = false;
            }
        }


        public void OpenWashingMachine()
        {
            washingMachine.isOpen = true;
        }

        public void CloseWashingMachine()
        {
            washingMachine.isOpen = false;
        }



    }
}