using System;

namespace condtions_and_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareValue = 20;
            int? result;
            Console.WriteLine("please enter you square value");
            squareValue = int.Parse(Console.ReadLine());
            result = square(squareValue);
            Console.WriteLine(result);
            plusTwo(20.0);
        }

        static int square(int i)
        {
            int value = i;
            return value * value;
        }

         static void plusTwo(double anyNumber)
        {
            int x = 2;
            double result = (anyNumber + x);
            Console.WriteLine("+2 value: "+result);
        }

        }
}
