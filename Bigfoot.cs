using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ConsoleApp
{
    internal class Bigfoot : IMammal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void PerformTrick()
        {
            Console.WriteLine($"Is that a bigfoot!?");
            Console.WriteLine($"Run, its performing a trick!");
        }
    }
}
