using System;
using Battle.Enum;

namespace Battle
{
    class Program
    {
        static Random rng = new Random();

        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("Halpert", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Schrute", Faction.BadGuy);

            while(goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
            }
        }
    }
}
