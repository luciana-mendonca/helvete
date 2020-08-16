using System;

namespace Helvete
{
    public class Player
    {
        Random rand = new Random();

        public int armor = 0;
        public int coins = 30000;
        public int damage = 1;
        public int health = 10;
        public string name;
        public int potion = 5;
        public int weapon = 1;

        // Difficulty modifier
        public int modifier = 0;

        public int GetPower()
        {
            int upper = (2 * modifier + 5);
            int lower = (modifier + 2);

            return rand.Next(lower, upper);
        }

        public int GetHealth()
        {
            int upper = (2 * modifier + 2);
            int lower = (modifier + 1);

            return rand.Next(lower, upper);
        }
    }
}
