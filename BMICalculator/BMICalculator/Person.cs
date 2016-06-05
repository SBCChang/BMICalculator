using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
   
    public class Person
    {
        protected float _height;
        protected float _weight;

        public float Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }

        public float Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public GenderType Gender { get; set; }

    }
}
