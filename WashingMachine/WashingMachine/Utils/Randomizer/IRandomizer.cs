using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Utils.Randomizer
{
    public interface IRandomizer
    {
        int RollAtRange(int min, int max);
    }
}
