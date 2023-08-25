using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Classes;

namespace SummationTask.Interface
{
    public interface INaturalSummation
    {
        SummationOutput Processs(double inputValue);
    }
}
