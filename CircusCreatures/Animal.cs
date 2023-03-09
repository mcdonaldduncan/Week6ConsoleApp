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

        public virtual string PerformTrick()
        {
            return $"{Name} does a trick!\n";
        }

        public virtual string GetInfo()
        {
            return $"Name = {Name}\nAge = {Age}";
        }
    }
}
