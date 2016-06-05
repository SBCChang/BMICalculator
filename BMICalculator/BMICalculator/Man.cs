using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class Man : Person
    {
        
        //public Man()
        //{
        //    _hiLimit = 25;
        //    _loLimit = 20;
        //}

        //public override string GetBMIResult()
        //{
        //    if (BMI > 25)
        //    {
        //        return "太胖";
        //    }
        //    else if (BMI < 20)
        //    {
        //        return "太瘦";
        //    }
        //    else
        //    {
        //        return "適中";
        //    }
        //}
    }

    public class Woman : Person
    {

        //public Woman()
        //{
        //    _hiLimit = 22;
        //    _loLimit = 18;
        //}
        //public override string GetBMIResult()
        //{
       
        //    if (BMI > 22)
        //    {
        //        return "太胖";
        //    }
        //    else if (BMI < 18)
        //    {
        //        return "太瘦";
        //    }
        //    else
        //    {
        //        return "適中";
        //    }
        //}
    }

    public class BMIFactory<T> where T : IBMI, new()
    {
        //public BMIFactory()
        //{
        //    instance = new T();
        //}
            
        public IBMI GetInstance()
        {
            return new T();
        }
    }
}
