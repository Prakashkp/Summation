using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    public class NaturalSummationFacade : INaturalSeries
    {
        ISummation summation = null;
        public NaturalSummationFacade(ISummation _summation)
        {
            summation = _summation;
        }
        public SummationOutput Processs(double inputValue)
        {
            //input Process
            var processedInput = SummationInput.ProcessInput(inputValue);
            //calculate the summation
            return summation.Calculate(processedInput);
        }
    }
}
