using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter.Models
{
    public class Mummy : ICombustable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine($"You just killed the Mummy using {attack}.");
            }
        }

        public override string ToString()
        {
            return "The mummy is weak to Fire";
        }
    }
}
