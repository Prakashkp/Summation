using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    //concrete class of the output class
    public class SummationOutput : ISummationOutput
    {
        public double SummationResult { get; set; }
    }
}
