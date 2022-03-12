using MonsterHunter.Models;

Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

Mummy tuts = new Mummy();

VonRimmersmark.Ignite(tuts);

Ghast ghast = new Ghast();
VonRimmersmark.SplashWater(ghast);
VonRimmersmark.Ignite(ghast);
VonRimmersmark.SplashWater(tuts);