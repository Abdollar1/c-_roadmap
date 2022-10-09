using System;

namespace calling_method
{
    class Program:animalFeatures
    {
        public override String myFish()
        {
            return "Tilapia";
        }
        public override String goat(string name, string skinColor)
        {
            return base.goat(name, skinColor);
        }

        static void Main(string[] args)
        {

            Program newFish = new Program(); 
            newFish.myFish();
            String chefFish = newFish.myFish();
            Console.WriteLine("the new chef Fish is:{0}",chefFish);
            String newGoat = newFish.goat(name: "kaf", skinColor: "brown");
            Console.WriteLine("the result of goat: {}", newGoat);
  
        }

       
    }
}
