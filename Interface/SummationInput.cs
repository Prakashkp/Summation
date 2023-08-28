using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationTask.Interface
{
    /// <summary>
    /// this class can be used to process the input data
    /// </summary>
    public class SummationInput
    {
        public SummationInput() { }
        public double Data { get; set; }

        /// <summary>
        /// this method is used to process the input. consumer no need to have the complexity of handling data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static SummationInput ProcessInput(double data)
        {
            return new SummationInput() { Data = data };
        }
    }
}
