using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    public class NaturalSeriesSummation : Summation
    {
        private NaturalSeriesSummation() { }

        private static NaturalSeriesSummation objNaturalSeriesSummation = null;

        public static NaturalSeriesSummation Instance
        {
            get
            {
                if (objNaturalSeriesSummation == null)
                {
                    objNaturalSeriesSummation = new NaturalSeriesSummation();
                }
                return objNaturalSeriesSummation;
            }
        }
        public override SummationOutput Calculate(SummationInput input)
        {
            return new SummationOutput { SummationResult = (input.Data) * (input.Data + 1) / 2 };
        }
    }
}
