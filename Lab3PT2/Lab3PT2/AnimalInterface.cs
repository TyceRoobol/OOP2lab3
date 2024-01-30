using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3PT2
{
    internal interface IAnimal
    {
        string Height { get; }
        string Name { get; }
        string Color { get; }
        int Age { get; }
        abstract void Eat();
        string Cry();
    }
}
