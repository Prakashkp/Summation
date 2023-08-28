using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    /// <summary>
    /// Facade class for the consumer
    /// </summary>
    public class SummationFacade
    {
        public static SummationOutput ProcessType(Int16 summationType, double inputValue)
        {
            INaturalSummation summation;
            if(summationType == 1)
            {
                summation = new NaturalSummationFacade(SummationFactory.GetNaturalSeriesSummation());
            }
            else if(summationType == 2)
            {
                summation = new NaturalSquareSummationFacade(SummationFactory.GetNaturalSeriesSquareSummation());
            }
            else
            {
                return null;
            }
            return Process(summation, inputValue);

        }
        private static SummationOutput Process(INaturalSummation naturalSummation, double inputValue)
        {
            return naturalSummation.Processs(inputValue);
        }
    }
}
