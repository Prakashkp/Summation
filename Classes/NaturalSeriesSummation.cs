using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    /// <summary>
    /// this is the natural series summation class
    /// </summary>
    public class NaturalSeriesSummation : Summation
    {
        //restricted class instansiation
        private NaturalSeriesSummation() { }

        private static NaturalSeriesSummation? objNaturalSeriesSummation = null;
        //this is singleton instance property
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
        /// <summary>
        /// this methos is used for calculation for natural series number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override SummationOutput Calculate(SummationInput input)
        {
            return new SummationOutput { SummationResult = (input.Data) * (input.Data + 1) / 2 };
        }
    }
}
