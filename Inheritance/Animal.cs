using System;
namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {// give this class 4 members that all Animals have in common
            Console.WriteLine("An animal has been created!");
            Random r = new Random();
            DNA = r.Next(1, 1000000000);
        }
        public Int64 DNA { get; set; }
        public string LatinName { get; set; }
        public int Age { get; set; }
        public bool IsItAwesome { get; set; }
        public string CommonName { get; set; }

    }
}
