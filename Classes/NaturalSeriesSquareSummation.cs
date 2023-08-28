using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    /// <summary>
    /// This is the concreate class for the square series summation
    /// </summary>
    public class NaturalSeriesSquareSummation : Summation
    {
        //restricted class instansiation
        private NaturalSeriesSquareSummation() { }

        private static NaturalSeriesSquareSummation objNaturalSeriesSquareSummation = null;

        //this is singleton instance
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

        //calculation for natural series squeare number
        public override SummationOutput Calculate(SummationInput input)
        {
            return new SummationOutput { SummationResult = (input.Data) * (input.Data + 1) * (2 * input.Data + 1) / 6 };
        }
    }
}
