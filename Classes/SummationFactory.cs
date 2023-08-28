using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationTask.Classes
{
    /// <summary>
    /// This is the Factory class is used to get the summation instance for the class
    /// </summary>
    public class SummationFactory
    {
        //Default constructor
        public SummationFactory() { }
        /// <summary>
        /// This method is used to get the Natural Series Summation Instance
        /// </summary>
        /// <returns>NaturalSeriesSummation</returns>
        public static NaturalSeriesSummation GetNaturalSeriesSummation()
        {
            return NaturalSeriesSummation.Instance;
        }
        /// <summary>
        ///  This method is used to get the Natural Square Series Summation Instance
        /// </summary>
        /// <returns>NaturalSeriesSquareSummation</returns>
        public static NaturalSeriesSquareSummation GetNaturalSeriesSquareSummation()
        {
            return NaturalSeriesSquareSummation.Instance;
        }
        
    }
}
