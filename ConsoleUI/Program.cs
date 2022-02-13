using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /**
    * 2/12/2022
    * CSC 153
    * Kalie Kirch
    * The beggining of my Text adventure program for the school semester project.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int roomIndex = 0;
            //These are the arrays for the data
            string[] rooms = new string[5]{"Tomb of the Antecedent", "Library", "Crypt", "Hall of the Antecedent", "Stairway"};
            string[] weapons = new string[4]{"Mace", "Sword", "Boomerang" ,"Gunsaber" };
            string[] potions = new string[2]{"Elixir of Rage", "Elixir of Recovery"};
            string[] treasures = new string[3]{"Amulet of Canopus", "Scorpio's Frying Pan", "Emerald Orb"};
            //New Alphabetical weapons
            var sortedWeapons = weapons.OrderBy(x => x.ToLower()).ToArray();

            //Lists for catalogs
            List<string> items = new List<string>(){"Corn", "Kami's Kaleidoscope", "Bomb", "Canopus's Curse Block" };
            List<string> monsters = new List<string>(){ "Skeleman", "Robbin' Goblin", "Gravekeeper's Curse", "Anteatereatingant", "Doom Donuts" };
            //Main Menu

            while (exit == false)
            {
                Console.WriteLine($"You are currently inside: {rooms[roomIndex]}");
                Console.WriteLine("1. Display Rooms");
                Console.WriteLine("2. Display Weapons");
                Console.WriteLine("3. Display Potions");
                Console.WriteLine("4. Display Treasures");
                Console.WriteLine("5. Display Items");
                Console.WriteLine("6. Display Bestiary(Monsters)");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice ");
                string input = Console.ReadLine();


                switch (input.ToLower())
                {
                    case "1":
                        foreach (string value in rooms)
                        {
                            Console.WriteLine(value);
                        }
                        break;

                        //use new array to display weapons alphabetically
                    case "2":
                        foreach (string value in sortedWeapons)
                        {
                            Array.Sort(weapons);
                            Console.WriteLine(value);
                        }
                        break;
                        break;

                    case "3":
                        foreach (string value in potions)
                        {
                            Console.WriteLine(value);
                        }
                        break;
                        break;

                    case "4":
                        foreach (string value in treasures)
                        {
                            Console.WriteLine(value);
                        }
                        break;
                        break;

                    case "5":
                        foreach (string value in items)
                        {
                            Console.WriteLine(value);
                        }
                        break;
                        break;

                    case "6":
                        foreach (string value in monsters)
                        {
                            Console.WriteLine(value);
                        }
                        break;
                        break;

                    case "rooms":
                        foreach (string value in rooms)
                        {
                            Console.WriteLine(value);
                        }
                        break;

                        //use new array to display weapons alphabetically
                    case "weapons":
                        foreach (string value in sortedWeapons)
                        {
                            Array.Sort(weapons);
                            Console.WriteLine(value);
                        }
                        break;
                        break;

                    case "potions":
                        foreach (string value in potions)
                        {
                            Console.WriteLine(value);
                        }
                        break;
                        break;

                    case "treasures":
                        foreach (string value in treasures)
                        {
                            Console.WriteLine(value);
                        }
                        break;
                        break;

                    case "items":
                        foreach (string value in items)
                        {
                            Console.WriteLine(value);
                        }
                        break;
                        break;

                    case "bestiary":
                        foreach (string value in monsters)
                        {
                            Console.WriteLine(value);
                        }
                        break;
                        break;

                    case "7":
                        exit = true;
                        break;

                    case "n":
                        if (roomIndex != 4)
                        {
                            roomIndex++;
                        }
                        else
                        {
                            Console.WriteLine("You can not go north anymore!");
                        }
                        break;

                    case "s":
                        if (roomIndex != 0)
                        {
                            roomIndex--;
                        }
                        else
                        {
                            Console.WriteLine("You can no longer leave the tower, this journey is final");
                        }
                        break;

                    default:
                        Console.WriteLine("This is not an applicable choice");
                        break;
                }
            }
        }
    }
}
