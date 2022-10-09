using System;
using System.Threading.Tasks;

namespace passingParametersAsArrays
{
    class Program
    {
        static void Main()
        {
            optional opt = new optional();
            opt.values(required: 10, description: "we are null"); 
            opt.values(10,20 ); 
            opt.values(10,20 , "we are description");

            returnType ret = new returnType();
           int result =  ret.addNumber(10, 20);
           result = ret.multipleNumber(result);
            Console.WriteLine(result);

           result = ret.multipleNumber(ret.addNumber(10, 20));
            Console.WriteLine(result);

            ret.dividNumber(20,10);
            int x = 10; int y = 20;
            Console.WriteLine($"{"direct x:"+x + " "+ "direct y:"+y}");
            ret.passingValue(ref x, ref y);

             ret.arrayThings();
            ret.DelayAsync();


        }
         
        public class optional
        {

            public void values(int required, int optionList = default, string? description = default)
            {
                var message = $"{description ?? "n/a"}: {required} + {optionList} + {required + optionList}";

                Console.WriteLine(message);
            }

            }

        }

     class returnType
    {
        public int addNumber(int x, int y)
        {
            return x + y;
        }
        
        public int multipleNumber(int x)
        {
            return x*x;
        }


        public void dividNumber(int x, int y)
        {

            int result = x / y;


            Console.WriteLine(result);
        }

        public void passingValue(ref int x, ref int y){

            int pass = x;
            x = y;
            y = pass;
            Console.WriteLine("ref x: " + x + "ref y"+ y );

        }


        public void arrayThings()
        {
            int[] singleArray = { 10, 20, 30, 40, 50 };
            foreach (var lis in singleArray)
            {
               Console.WriteLine("the Lisf for each: "+lis);
            }
}
        

        public async Task<int> DelayAsync()
        {
            await Task.Delay(200);
            return 5;
        }
        }
    }
