using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class TopMenu
    {

        public static int CounterTopMenu;
        public static  void LaunchMenu()
        {

            string[] topMenu = { "ПРАЙСЛИСТ", Included.TopMenuElement2, Included.TopMenuElement3 };
            while (true)
            {
                Console.Clear();
                for (var i = 0; i < topMenu.Length; i++)
                {
                    if (CounterTopMenu == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\t\t   > {topMenu[i]} <\t\t");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"\t\t     {topMenu[i]}  \t\t");
                    }

                }

                Console.WriteLine("\n\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.RightArrow when CounterTopMenu < topMenu.Length - 1:
                        CounterTopMenu++;
                        break;

                    case ConsoleKey.LeftArrow when CounterTopMenu > 0:
                        CounterTopMenu--;
                        break;

                    case ConsoleKey.DownArrow:
                        return;


                }
            }
        }

    }
}
