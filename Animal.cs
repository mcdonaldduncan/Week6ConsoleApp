using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ConsoleApp
{
    abstract class Animal : IMammal
    {
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 0;

        public Animal()
        {

        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void PerformTrick()
        {
            Console.WriteLine($"{Name} does a trick!");
        }

        public virtual string GetInfo()
        {
            return $"Name = {Name}\nAge = {Age}";
        }
    }
}
