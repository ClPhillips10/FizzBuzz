using System;

namespace FizzBuzz;
class program 
{


static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
            {
            bool Fizz = i % 3 == 0;
            bool Buzz = i % 5 == 0;

            if (Fizz == true && Buzz == false)
            {
                Console.WriteLine($"{i} is Fizz");

            }
            if (Buzz == true && Fizz == false)
            {
                Console.WriteLine($"{i} is Buzz");
            }
            if(Fizz == true && Buzz == true)
            {
                Console.WriteLine($"{i} is FizzBuzz");
            }
           

        }



}
}