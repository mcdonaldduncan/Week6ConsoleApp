using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ConsoleApp
{
    internal class Lizard : Animal
    {
        public Lizard(string name, int age) : base(name, age)
        {

        }

        public override void PerformTrick()
        {
            base.PerformTrick();
            Console.WriteLine($"The {Name} detaches its tail and flings it at the crowd!");
        }

    }
}
