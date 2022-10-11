using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static string weapon = "Bazooka";
        static int health = 100;
        static string healthStatus = "Perfect Health";

        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals:");
            Console.WriteLine("-------------");
            Console.WriteLine("");

            ChangeWeapon(2);
            TakeDamage(90);
            Heal(10);
            ShowHUD();

            Console.ReadKey(true);
        }

        static void ChangeWeapon(int weaponPickedUp)
        {
            string lastWeapon = weapon;

            if (weaponPickedUp == 1)
            {
                weapon = "Bazooka";
            }
            else if (weaponPickedUp == 2)
            {
                weapon = "Rocket Launcher";
            }
            else if (weaponPickedUp == 3)
            {
                weapon = "Explosive Balloon";
            }
            else if (weaponPickedUp == 4)
            {
                weapon = "Flimsy Sword";
            }
            else
            {
                weapon = "Water Gun";
            }

            Console.WriteLine("Player changed their " + lastWeapon + " to a " + weapon);
        }

        static void TakeDamage(int damage)
        {
            health -= damage;
            if (health < 0)
            {
                health = 0;
            }

            Console.WriteLine("Player took " + damage + " damage");
            Console.WriteLine("Player's health is now " + health);
        }

        static void Heal(int hp)
        {
            health += hp;
            if (health > 100)
            {
                health = 100;
            }

            Console.WriteLine("Player healed " + hp + " health");
            Console.WriteLine("Player's health is now " + health);
        }

        static void ShowHUD()
        {
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Weapons Stored: Bazooka, Rocket Launcher, Explosive Balloon, Flimsy Sword, Water Gun");

            if (health > 0 && health < 10)
            {
                healthStatus = "Imminent Danger";
            }
            else if (health >= 10 && health < 50)
            {
                healthStatus = "Badly Hurt";
            }
            else if (health >= 50 && health < 75)
            {
                healthStatus = "Hurt";
            }
            else if (health >= 75 && health < 100)
            {
                healthStatus = "Healthy";
            }
            else
            {
                healthStatus = "Perfect Health";
            }

            Console.WriteLine("Health Status: " + healthStatus);
        }
    }
}
