using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationTask.Interface
{
    //this class can be used to process the input data
    public class SummationInput
    {
        public SummationInput() { }
        public double Data { get; set; }

        public static SummationInput ProcessInput(double data)
        {
            return new SummationInput() { Data = data };
        }
    }
}
