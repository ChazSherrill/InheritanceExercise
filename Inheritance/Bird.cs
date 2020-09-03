using System;
namespace Inheritance
{
    public class Bird : Animal, IAnimal_Prints
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public Bird()
        {
            Console.WriteLine("A Bird has been created, unfortunately");
            IsItAwesome = false;
        }
        public bool CanItFly { get; set; }
        public string ColorOfFeathers { get; set; }
        public int WingSpan { get; set; }
        public bool DoesItHaveLargeTalons { get; set; }

        public void PrintInfo()
        {
            if (IsItAwesome)
            {
                Console.WriteLine($"The illustrious {CommonName} is insane. This one has an age of {Age}.");
            }
            else
            {
                Console.WriteLine($"It is a piece of trash is called a {CommonName}. It has lived way to long at {Age} years old.");
            }
            
            if (CanItFly)
            {
                Console.WriteLine($"I know what your thinking and yes it's {CanItFly} it can fly");
            }
            else
            {
                Console.WriteLine("It can't fly. I know what's the point of it being a bird.");
            }
            Console.WriteLine($"The color of it's feathers are {ColorOfFeathers}");
            Console.WriteLine($"The wingspan is {WingSpan} feet.");
            if (DoesItHaveLargeTalons)
            {
                Console.WriteLine("Thankfully it has large talons to eviserate it's pray.");
            }
            else
            {
                Console.WriteLine("It doesn't even have large talons of which it can be proud.");
            }
            Console.WriteLine($"Not that you care but it's latin name is {LatinName} and if you know what DNA is then it's fake DNA is {DNA}.");
        }
    }
}
