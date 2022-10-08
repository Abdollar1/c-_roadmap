using System;

namespace step_1_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int age;
            double myResult = 10.20; 
            Console.WriteLine(myResult);
            Console.WriteLine("Enter your result");

            myResult = double.Parse(Console.ReadLine());
            Console.WriteLine(myResult);
            Console.WriteLine((float)myResult);
            Console.WriteLine("Name");
            name = Console.ReadLine();
            Console.WriteLine("age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(name + " "+ age);
        }
    }
}
