using System;
using WashingMachine.Enums;

namespace WashingMachine.Entities.Cloth
{
    public class Dress : ICloth
    {
        public CleanType currentState => CleanType.Dirty;
    }
}
