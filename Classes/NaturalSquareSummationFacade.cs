using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    //facade class to process natura quare n number
    public class NaturalSquareSummationFacade : INaturalSquareSeries
    {
        ISummation summation = null;
        //dependency inject for dependent class
        public NaturalSquareSummationFacade(ISummation _summation)
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
