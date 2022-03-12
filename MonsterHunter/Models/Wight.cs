using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter.Models
{
    public class Wight : IDouseable
    {
        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine($"You just killed the Mummy using {attack}.");
            }
            else
            {
                Console.WriteLine($"Your {attack} had no effect.");
            }
        }

        public override string ToString()
        {
            return "wight";
        }
    }
}
