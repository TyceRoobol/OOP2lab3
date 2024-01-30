using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3PT2
{
    internal class Dog: IAnimal
    {
        public string Height { get; set; }
        public string Name { get; set; }

        public string Color { get; set; }

        public int Age { get; set; }

        public Dog (string height, string name, string color, int age)
        {
            Height = height;
            Name = name;
            Color = color;
            Age = age;
        }
        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public string Cry()
        {
            return "Woof!";
        }
        public void getInfo ()
        {
            Console.WriteLine(Height);
            Console.WriteLine(Name);
            Console.WriteLine(Color);
            Console.WriteLine(Age);
        }
    
    }
}
