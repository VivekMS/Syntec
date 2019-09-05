using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateBonus.Abstract
{
    public interface ICalculateEmployeeBonus
    {
        int CalculateBonusPercentage(int value1, int value2);
        int CalculateBonusAllocation(int val1, int val2);
    }
}
