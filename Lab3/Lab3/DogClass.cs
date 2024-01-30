﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Dog: Animal
    {
        public Dog(string name, string color, int age): base(name, color, age) {
        }
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public void GetInfo() {
            Console.WriteLine(Name);
            Console.WriteLine(Color);
            Console.WriteLine(Age);
        }
    }
}
