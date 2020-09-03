using System;
namespace Inheritance
{
    public class Reptiles : Animal, IAnimal_Prints
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
        public Reptiles()
        {
            Console.WriteLine("A reptile has been created.");
            IsItAwesome = true;
        }

        public bool DetachableTail { get; set; }
        public int NumberOfClaws { get; set; }
        public string Biggness { get; set;}
        public bool IsItADinosaur { get; set; }

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

            if (DetachableTail)
            {
                Console.WriteLine("This magnificent beast can let it's tail go to get away from predators.");
            }
            else
            {
                Console.WriteLine("It dearly loves it's tail.");
            }
            Console.WriteLine($"This thing has alot of claws at {NumberOfClaws} claws.");
            Console.WriteLine($"The bigness of this thing would be described as {Biggness}.");
            if (IsItADinosaur)
            {
                Console.WriteLine("This thing is a freaking dinosaur. Jurassic park is legit");
            }
            else
            {
                Console.WriteLine("Unforturnately this thing is not a dinosaur it's too new or it's a crocodile.");
            }
            Console.WriteLine($"Not that you care but it's latin name is {LatinName} and if you know what DNA is then it's fake DNA is {DNA}.");
        }
    }
}
