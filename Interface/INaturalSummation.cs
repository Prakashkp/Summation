﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummationTask.Classes;

namespace SummationTask.Interface
{
    // interface for all the summation class contains base process signature required for all the concreete class
    public interface INaturalSummation
    {
        //base process signature required for all the concreete class
        SummationOutput Processs(double inputValue);
    }
}
