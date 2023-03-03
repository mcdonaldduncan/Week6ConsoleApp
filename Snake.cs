using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ConsoleApp
{
    internal class Snake : Animal
    {
        bool IsVenomous;
        string VenomType;


        public Snake(string name, int age) : base(name, age)
        {
            VenomType = "None";
            IsVenomous = false;
        }

        public Snake(string name, int age, string venomType) : base(name, age)
        {
            VenomType = venomType;
            IsVenomous = true;
        }

        public override void PerformTrick()
        {
            base.PerformTrick();
            Console.WriteLine($"The {Name} dislocates its jaw, scaring the entire crowd!");
        }

    }
}
