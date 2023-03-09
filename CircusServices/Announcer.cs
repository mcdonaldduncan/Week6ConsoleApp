using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ConsoleApp
{
    internal class Announcer
    {
        public void AnnounceCreature(IMammal creature)
        {
            Console.WriteLine($"Behold the amazing {creature.Name}!");
            Console.WriteLine($"The creature is {creature.Age} years old!");
            Console.WriteLine(creature.PerformTrick());
        }

    }
}
