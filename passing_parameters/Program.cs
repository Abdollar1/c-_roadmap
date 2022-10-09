using System;

namespace passing_parameters
{
    class Program
    {
      

        public static void Main( )
        {
          int firstValue = 10;
        Console.WriteLine("the assigned value: "+ firstValue);
            insert(ref firstValue);

            Console.WriteLine("the main value: " +  firstValue);

            int i = 2; int j = 3;
           Console.WriteLine("i = {0}:" + i + " " + "j = {0}:" + j);
            swap(ref i, ref j);
            Console.WriteLine("i = {0}:" + i + " " + "j = {0}:" + j);
        }

         static void insert(ref int value)
        {
           value = 100;
            Console.WriteLine("the next value was: " + value);
            return;
        }

        static void swap(ref int x,ref int y)
        {
            int myValue = x;
            x = y;
            y = myValue;
        }

        }
}
