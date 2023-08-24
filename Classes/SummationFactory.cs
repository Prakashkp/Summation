using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationTask.Classes
{
    public class SummationFactory
    {
        public SummationFactory() { }
        public static NaturalSeriesSummation GetNaturalSeriesSummation()
        {
            return NaturalSeriesSummation.Instance;
        }
        public static NaturalSeriesSquareSummation GetNaturalSeriesSquareSummation()
        {
            return NaturalSeriesSquareSummation.Instance;
        }
    }
}
