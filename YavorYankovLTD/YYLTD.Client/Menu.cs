using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYLTD.Client
{
    public class Menu
    {
        public static void Items()
        {
            //Current option
            int item = 0;

            ConsoleKeyInfo key;

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

                item = PrintMenuItems(item, menuItems);

                key = Console.ReadKey(true);

                item = PressedKey(key, item, menuItems);
                
            } while (key.Key.ToString() != "Enter");

            //switch (item)
            //{
            //    case 2:
            //        Options.Exit();
            //        break;
            //}
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
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.ResetColor();

                if (item == i)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(menuItems[i]);
                }
                else
                    Console.WriteLine(menuItems[i]);

            }
            return item;
        }
    }
}
