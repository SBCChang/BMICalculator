﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public interface IBMI
    {
        double CalculateBMI();

        string GetBMIResult();
    }
}