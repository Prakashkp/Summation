using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Interface;

namespace SummationTask.Classes
{
    /// <summary>
    /// concrete class of the output. can be extented
    /// </summary>
    public class SummationOutput : ISummationOutput
    {
        public double SummationResult { get; set; }
    }
}
