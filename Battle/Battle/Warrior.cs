using Battle.Enum;
using Battle.Equipment;

namespace Battle
{
    class Warrior
    {
        private int goodGuyStartingHealth;
        private int badGuyStartingHealth;

        private Faction faction;

        private int health;
        private int name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

    }
}
