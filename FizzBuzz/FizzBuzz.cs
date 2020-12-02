using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public void CheckFizzBuzz(int number)
        {
           
            if(number % 3 == 0 && number % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if(number % 3 == 0)
                Console.WriteLine("Fizz");
            else if(number % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(number);
        }
    }
}
