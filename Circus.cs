using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6ConsoleApp.CircusServices;
using Week6ConsoleApp.Models;

namespace Week6ConsoleApp
{
    internal class Circus
    {
        RosterService rosterService = new RosterService();

        Announcer announcer = new Announcer();

        public void PerformCircus()
        {
            List<IMammal> roster = rosterService.GenerateRoster();

            foreach (var creature in roster)
            {
                announcer.AnnounceCreature(creature);
            }


            roster.Where(x => x is not Animal).ToList().ForEach(x => Console.WriteLine(x.GetType()));
        }

    }
}
