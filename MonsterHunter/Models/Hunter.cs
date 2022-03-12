using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunter.Models
{
    public class Hunter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Weapons { get; } = new List<string>() {
            "Silver", "Fire", "Holy Water"
            };

        public Hunter(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public void SplashWater(IDouseable enemy)
        {
            enemy.Douse("Holy Water");  // Kills with holy water
        }


        public void Ignite(ICombustable enemy)
        {
            enemy.Burn("Fire");  // Kills with fire
        }

        public void WieldSilver(IStabable enemy)
        {
            enemy.Stab("Silver");   // Stabs with silver knife
        }
    }
}
