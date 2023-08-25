﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationTask.Interface
{
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
