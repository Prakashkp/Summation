using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    public class NaturalSeriesSquareSummation : Summation
    {
        private NaturalSeriesSquareSummation() { }

        private static NaturalSeriesSquareSummation objNaturalSeriesSquareSummation = null;

        public static NaturalSeriesSquareSummation Instance
        {
            get
            {
                if (objNaturalSeriesSquareSummation == null)
                {
                    objNaturalSeriesSquareSummation = new NaturalSeriesSquareSummation();
                }
                return objNaturalSeriesSquareSummation;
            }
        }
        public override SummationOutput Calculate(SummationInput input)
        {
            return new SummationOutput { SummationResult = (input.Data) * (input.Data + 1) * (2 * input.Data + 1) / 6 };
        }
    }
}
