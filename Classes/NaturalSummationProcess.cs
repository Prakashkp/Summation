using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    /// <summary>
    /// This is Facade class to process the natural summation of n number
    /// </summary>
    public class NaturalSummationFacade : INaturalSeries
    {
        ISummation summation = null;
        public NaturalSummationFacade(ISummation _summation)
        {
            summation = _summation;
        }

        /// <summary>
        /// this method will process the summation method hide the complexity process to the consumer
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public SummationOutput Processs(double inputValue)
        {
            //input Process
            var processedInput = SummationInput.ProcessInput(inputValue);
            //calculate the summation
            return summation.Calculate(processedInput);
        }
    }
}
