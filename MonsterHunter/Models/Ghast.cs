using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter.Models
{
    public class Ghast : ICombustable, IDouseable
    {
        public void Burn(string attack)
        {
            Console.WriteLine("You killed the ghast by burning it to a pile of ash.");
        }

        public void Douse(string attack)
        {
            Console.WriteLine("You killed the ghast by dousing it with holy water.");
        }

    }
}
