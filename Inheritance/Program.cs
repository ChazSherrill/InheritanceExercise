using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird baldEagle = new Bird();

            baldEagle.Age = 32;
            baldEagle.CanItFly = true;
            baldEagle.ColorOfFeathers = "Brown and White";
            baldEagle.IsItAwesome = true;
            baldEagle.DoesItHaveLargeTalons = true;
            baldEagle.LatinName = "Haliaeetus leucocephalus";
            baldEagle.WingSpan = 7;
            baldEagle.CommonName = "Bald Eagle";

            baldEagle.PrintInfo();



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Reptiles tRex = new Reptiles();

            tRex.Age = 144324;
            tRex.NumberOfClaws = 6;
            tRex.DetachableTail = false;
            tRex.CommonName = "The Freaking T-REX";
            tRex.LatinName = "Tyrannosaurus";
            tRex.Biggness = "YUUUUGGGEE";
            tRex.IsItADinosaur = true;

            tRex.PrintInfo();




        }
    }
}
