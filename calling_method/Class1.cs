using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    abstract class animalFeatures
    {
        public void fish(String name, String fineType, String color)
        {
            Console.WriteLine("name:" + name, "Fine Type:" + fineType, "Color: " + color);
        }
        // public void goat(String name, String fineType, String color)
        //{
        //    Console.WriteLine("name:" + name, "Fine Type:" + fineType, "Color: " + color);
        //}

        public void cat(String name, String fineType, String color)
        {
            Console.WriteLine("name:" + name, "Fine Type:" + fineType, "Color: " + color);
        }

    public virtual String goat(String name, String skinColor) {
        return name;
            }
        public abstract String myFish();

    }