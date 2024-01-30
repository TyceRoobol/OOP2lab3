using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Cat: Animal
    {
        public Cat(string name, string color, int age): base(name, color, age) { }
        public override void Eat()
        {
            Console.WriteLine("Cats eat Mice");
        }
        public void GetInfo() { 
            Console.WriteLine(Name);
            Console.WriteLine(Color);
            Console.WriteLine(Age);
        }
    }
}
