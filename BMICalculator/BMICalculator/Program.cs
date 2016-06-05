using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person man = new Person() { Height = 1.68f, Weight = 72, Gender = GenderType.Man };
            Console.WriteLine(BMI.GetBMIResult(man));

            Person woman = new Person() { Height = 1.58f, Weight = 40, Gender = GenderType.Woman };
            Console.WriteLine(BMI.GetBMIResult(woman));


            Console.ReadKey();
        }
    }
}
