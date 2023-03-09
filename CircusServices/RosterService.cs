using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6ConsoleApp.Models;

namespace Week6ConsoleApp.CircusServices
{
    internal class RosterService
    {
        NamingService namingService = new NamingService();

        public List<IMammal> GenerateRoster()
        {
            List<IMammal> masterList = new List<IMammal>();

            for (int i = 0; i < 3; i++)
            {
                Lizard lizard = new Lizard(namingService.GetRandomName(), i);
                masterList.Add(lizard);

                if (i % 2 == 0)
                {
                    Snake snake = new Snake(namingService.GetRandomName(), i, "hemotoxic");
                    masterList.Add(snake);
                }
                else
                {
                    Snake snake = new Snake(namingService.GetRandomName(), i);
                    masterList.Add(snake);
                }


                Bigfoot bigfoot = new Bigfoot(namingService.GetRandomName(), i);
                masterList.Add(bigfoot);
            }

            return masterList;
        }
    }
}
