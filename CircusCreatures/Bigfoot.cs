using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6ConsoleApp.Models;

namespace Week6ConsoleApp
{
    internal class Bigfoot : IMammal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Bigfoot(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string PerformTrick()
        {
            string temp = $"Is that a bigfoot!?\n";
            temp += $"Holy cow, its performing a trick!\n";
            return temp;
        }
    }
}
