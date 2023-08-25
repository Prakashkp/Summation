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
        //restricted class instansiation
        private NaturalSeriesSummation() { }

        private static NaturalSeriesSummation? objNaturalSeriesSummation = null;
        //singleton instance
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
        //calculation for natural series number
        public override SummationOutput Calculate(SummationInput input)
        {
            return new SummationOutput { SummationResult = (input.Data) * (input.Data + 1) / 2 };
        }
    }
}
