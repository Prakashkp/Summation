using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    /// <summary>
    /// facade class to process natural square n number
    /// </summary>
    public class NaturalSquareSummationFacade : INaturalSquareSeries
    {
        ISummation summation = null;
        /// <summary>
        /// dependency inject for dependent class
        /// </summary>
        /// <param name="_summation"></param>
        public NaturalSquareSummationFacade(ISummation _summation)
        {
            summation = _summation;
        }

        /// <summary>
        /// this method is to process the summation. hides the complexity from the consumer
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
