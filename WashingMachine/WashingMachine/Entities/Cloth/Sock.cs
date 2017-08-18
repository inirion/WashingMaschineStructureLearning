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
        public CleanType currentState => CleanType.Dirty;
    }
}
