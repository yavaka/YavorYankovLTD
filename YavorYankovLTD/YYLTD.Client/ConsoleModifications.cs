using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYLTD.Client
{
    public class ConsoleModifications
    {
        public static void Run()
        {
            SetSize();
            CursorVisible();
        }

        public static void SetSize() => Console.SetWindowSize(80, 20);

        public static void CursorVisible() => Console.CursorVisible = false;

        public static void TextAlign()
        {
            for (int i = 0; i < 8; i++)
                Console.WriteLine();
        }

        public static void SetCursorPosition(int iteration, int menuItemLenght)
        {
            Console.SetCursorPosition(
                (Console.WindowWidth - menuItemLenght) / 2
                , Console.CursorTop);
        }

        public static void ChangeColour()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}
