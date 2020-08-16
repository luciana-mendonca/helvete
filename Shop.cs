using System;

namespace Helvete
{

    public class Shop
    {
        public static void LoadShop(Player p)
        {
            RunShop(p);
        }

        public static void RunShop(Player p)
        {
            int potionPrice;
            int armorPrice;
            int weaponPrice;
            int diffPrice;

            while(true)
            {
                potionPrice = 20 + 10 * p.modifier;
                armorPrice = 100 * (p.armor + 1);
                weaponPrice = 100 * (p.weapon);
                diffPrice = 300 + 100 * p.modifier;

                Console.Clear();
                Console.WriteLine("           Shop           ");
                Console.WriteLine("===========================");
                Console.WriteLine("(W)eapon: $" + weaponPrice);
                Console.WriteLine("(A)rmor: $" + armorPrice);
                Console.WriteLine("(P)otion: $" + potionPrice);
                Console.WriteLine("(D)ifficulty: $" + diffPrice);
                Console.WriteLine("===========================");
                Console.WriteLine("|       (E)xit            |");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(p.name + "'s Stats         ");
                Console.WriteLine("===========================");
                Console.WriteLine("Coins:   " + p.coins);
                Console.WriteLine("Health: " + p.health);
                Console.WriteLine("Weapon: " + p.weapon);
                Console.WriteLine("Armor: " + p.armor);
                Console.WriteLine("Potions: " + p.potion);
                Console.WriteLine("Difficulty Modifiers: " + p.modifier);
                Console.WriteLine("===========================");

                //Wait for input
                string input = Console.ReadLine().ToLower();

                if(input == "w" || input == "weapon")
                {
                    Buy("weapon", weaponPrice, p);
                }
                else if(input == "a" || input == "armor")
                {
                    Buy("armor", armorPrice, p);
                }
                else if (input == "p" || input == "potion")
                {
                    Buy("potion", potionPrice, p);
                }
                else if (input == "d" || input == "difficulty")
                {
                    Buy("difficulty", diffPrice, p);
                }
                else if(input == "e" || input == "exit")
                {
                    break;
                }

                static void Buy(string item, int price, Player p)
                {
                    if(p.coins >= price)
                    {
                        if(item == "weapon")
                        {
                            p.weapon++;
                        }
                        else if(item == "armor")
                        {
                            p.armor++;
                        }
                        else if(item == "potion")
                        {
                            p.potion++;
                        }
                        else if(item == "difficulty")
                        {
                            p.modifier++;
                        }
                        p.coins -= price;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough coins!");
                        Console.ReadKey();
                    }
                }

            }
        }
    }
}
