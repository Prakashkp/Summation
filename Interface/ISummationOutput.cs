using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationTask.Interface
{
    // output interface and contains result signature 
    internal interface ISummationOutput
    {
        double SummationResult { get; set; }
    }
}
