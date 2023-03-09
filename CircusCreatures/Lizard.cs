using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ConsoleApp.Models
{
    internal class Lizard : Animal
    {
        public Lizard(string name, int age) : base(name, age)
        {

        }

        public override string PerformTrick()
        {
            string temp = base.PerformTrick();

            temp += $"{Name} detaches its tail and flings it at the crowd!\n";

            return temp;
        }

    }
}
