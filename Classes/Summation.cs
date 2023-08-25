using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    //based abstract class open for extension
    public abstract class Summation : ISummation
    {
        public Summation()
        {
        }

        public abstract SummationOutput Calculate(SummationInput input);
    }
}
