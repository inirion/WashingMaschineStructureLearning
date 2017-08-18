using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WashingMachine.Enums;

namespace WashingMachine.Entities.Cloth
{
    public class Sock : ICloth
    {
        private CleanType _currentState = CleanType.Dirty;

        public CleanType currentState {
        get {
                return _currentState;
            }
        set {
                _currentState = value;
            }
        }
        
    }
}
