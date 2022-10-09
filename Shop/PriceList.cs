using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class PriceList
    {
        public static int CounterProductIner;  
        public static void LaunchPrice(List<string> productMenu)
        {

            string[] topMenu = { "Один", "Два", "Три" };
            //string[] productMenu = { "Dblz[f", "Ghjw", ":tcn" };

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < topMenu.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"\t\t     {topMenu[i]}  \t\t");
                }
                Console.WriteLine("\n\n\n");


                for (var i = 0; i < productMenu.Count; i++)
                {
                    if (CounterProductIner == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{productMenu[i]}\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{productMenu[i]}\n");
                    }


                }

                Console.WriteLine("\n\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.DownArrow when CounterProductIner < productMenu.Count - 1:
                        CounterProductIner++;
                        break;
                    case ConsoleKey.DownArrow:
                        CounterProductIner = 0;
                        break;
                    case ConsoleKey.UpArrow when CounterProductIner > 0:
                        CounterProductIner--;
                        break;
                    case ConsoleKey.UpArrow when CounterProductIner == 0:
                        return;
                    case ConsoleKey.Escape:
                        return;
                        /*case ConsoleKey.Enter:
                            return;*/ //           повесим выполнение покупки

                }
            }
        }
    }
}
