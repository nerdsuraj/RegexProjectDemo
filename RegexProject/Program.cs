using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProject
{
    internal class Program
    {
  
        static void Main(string[] args)
        {
            Console.WriteLine("hello regex :-) ");
            Patterns patterns = new Patterns();
            Console.WriteLine(patterns.ValidatePinCode("828104"));
            Console.WriteLine(patterns.ValidateEmailID("adh212au.parag64@gmail.co.in"));
            Console.WriteLine(patterns.ValidatePhoneNum("+91-6200749278"));
            Console.WriteLine(patterns.ValidatePassword("S@uraj62"));

            Console.ReadLine();
        }
    }
}
