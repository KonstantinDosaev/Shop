using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class VerticalMenu
    {
        public static int CounterProductVertical;
        
        public static void GetVerticalMenu()
        {
            
            List<string> variantProduct = new List<string>(){ "ВИДЕОКАРТА","ЖЕСТКИЙ ДИСК" };
            while (true)
            { 
                Console.Clear();
                for (var i = 0; i < variantProduct.Count; i++)
                {
                    if (CounterProductVertical == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(variantProduct[i]);

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(variantProduct[i]);
                    }
                }
                switch (Console.ReadKey().Key)
                {

                    case ConsoleKey.DownArrow when CounterProductVertical < variantProduct.Count - 1:
                        CounterProductVertical++;
                        break;
                    case ConsoleKey.DownArrow:
                        CounterProductVertical = 0;
                        break;
                    case ConsoleKey.UpArrow when CounterProductVertical > 0:
                        CounterProductVertical--;
                        break;
                    case ConsoleKey.UpArrow when CounterProductVertical == 0:
                        return;
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.Enter:
                        CreatingList.AddProduct();
                        return;

                }
            }
        }
    }
}
