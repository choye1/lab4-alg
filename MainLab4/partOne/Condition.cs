using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partOne
{
    internal class Condition
    {
        private int cond;
        private SelectSort values;

        public Condition(int cond, SelectSort values)
        {
            this.cond = cond;
            this.values = values;   
        }

        public List<int> ConditionSelectSort()
        {
            List<int> conditionRes = values.Sort(cond);

            return conditionRes;
        }
    }
}
