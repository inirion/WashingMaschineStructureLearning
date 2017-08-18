using System;
using WashingMachine.Enums;

namespace WashingMachine.Entities.Cloth
{
    public class Dress : ICloth
    {
        private CleanType _currentState = CleanType.Dirty;

        public CleanType currentState
        {
            get
            {
                return _currentState;
            }
            set
            {
                _currentState = value;
            }
        }
    }
}
