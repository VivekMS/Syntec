using CalculateBonus.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateBonus.Concrete
{
    public class CalculateEmployeeBonus : ICalculateEmployeeBonus
    {
        public int CalculateBonusAllocation(int val1, int val2)
        {
            return val1 * val2;
        }

        public int CalculateBonusPercentage(int value1, int value2)
        {
            return value1 / value2;
        }
    }
}
