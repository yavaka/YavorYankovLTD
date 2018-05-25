using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYLTD.Client
{
    public class Menu
    {
        //Current option
        private static int Item { get; set; }

        private static ConsoleKeyInfo Key { get; set; }

        public static void Items()
        {
            
            string[] menuItems =
            {
                "Add journey",
                "Calendar",
                "Exit"
            };

            //Loop iterate all options 
            do
            {
                Console.Clear();

                 
                Item = PrintMenuItems(Item, menuItems);

                Key = Console.ReadKey(true);

                Item = PressedKey(Key, Item, menuItems);
                
            } while (Key.Key.ToString() != "Enter");

            switch (Item)
            {
                case 0:
                    Options.AddJourney();
                    break;
                case 2:
                    Options.Exit();
                    break;
            }
        }

        private static int PressedKey (ConsoleKeyInfo key, int item, string[] menuItems)
        {
            switch (key.Key.ToString())
            {
                case "DownArrow":
                    item++;
                    if (item > menuItems.Length - 1)
                        item = 0;
                    break;
                case "UpArrow":
                    item--;
                    if (item < 0)
                        item = menuItems.Length - 1;
                    break;
            }
            return item;
        }

        private static int PrintMenuItems(int item, string[] menuItems)
        {
            ConsoleModifications.TextAlign();

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.ResetColor();
                ConsoleModifications.SetCursorPosition(i, menuItems[i].Length);
                if (item == i)
                {
                    ConsoleModifications.ChangeColour();
                    Console.WriteLine(menuItems[i]);
                }
                else
                {
                    Console.WriteLine(menuItems[i]);
                }

            }
            return item;
        }
    }
}
