using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BMICalculator
{

    public static class BMI
    {
        private static int _hiLimit;
        private static int _loLimit;

        //public double BMIvalue
        //{
        //    get { return CalculateBMI(); }
        //}

        public static double CalculateBMI(Person person)
        {
            return person.Weight / Math.Pow(person.Height, 2);
        }

        public static string GetBMIResult(this Person person)
        {
            double bmi = CalculateBMI(person);
            SetLimit(person);

            if (bmi > _hiLimit)
            {
                var member = typeof(BMIRank).GetMember(BMIRank.heavy.ToString());
                var attributes = member[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                return ((DescriptionAttribute)attributes[0]).Description;

            }
            else if (bmi < _loLimit)
            {
                var member = typeof(BMIRank).GetMember(BMIRank.thin.ToString());
                var attributes = member[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                return ((DescriptionAttribute)attributes[0]).Description;
            }
            else
            {
                //return Enum.GetName(typeof(BMIRank), 0);
                var member = typeof(BMIRank).GetMember(BMIRank.middle.ToString());
                var attributes = member[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                return ((DescriptionAttribute)attributes[0]).Description;
            }
        }

        private static void SetLimit(Person person)
        {
            if (person.Gender == GenderType.Man)
            {
                _hiLimit = 25;
                _loLimit = 20;
            }
            else
            {
                _hiLimit = 22;
                _loLimit = 18;
            }
        }

    }
}
