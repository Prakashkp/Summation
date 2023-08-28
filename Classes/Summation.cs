using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    /// <summary>
    /// this is the base abstract class open for extension
    /// </summary>
    public abstract class Summation : ISummation
    {
        public Summation()
        {
        }

        /// <summary>
        /// This is the abstact method needed for all the inherited subsystem
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public abstract SummationOutput Calculate(SummationInput input);
    }
}
