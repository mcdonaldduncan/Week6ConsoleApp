using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6ConsoleApp.Models;

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

        public override string PerformTrick()
        {
            string temp = base.PerformTrick();
            temp += $"{Name} dislocates its jaw, scaring the entire crowd!\n";
            if (IsVenomous)
            {
                temp += "Watch out, its venemous!\n";
            }

            return temp;
        }

    }
}
