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
            
            string[] topMenu = { "ПРАЙСЛИСТ", Included.TopMenuElement2, Included.TopMenuElement3 };
            

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
                //Console.WriteLine("ПРОБЕЛ - ДОБАВИТЬ ПРОДУКТ....DELETE - УДАЛИТЬ");
                Console.WriteLine("\n\n");

                if (Included.NameUser == "admin")
                {
                    switch (TopMenu.CounterTopMenu)
                    {
                        case 0:
                            Console.WriteLine("ПРОБЕЛ - ДОБАВИТЬ ПРОДУКТ....DELETE - УДАЛИТЬ");
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

                                case ConsoleKey.Delete:
                                    Console.WriteLine("ПРОДУКТ УДАЛЕН");
                                    ProductManipulation.DeleteProduct();
                                    break;
                                case ConsoleKey.Spacebar:
                                    CreatingList.AddProduct();//пробел добавить
                                    break;
                                case ConsoleKey.Escape:
                                    return;
                                /*case ConsoleKey.Enter:
                                return;*/ //           повесим выполнение покупки

                            }
                            
                            break;
                        case 1:
                            Console.WriteLine("ПРОБЕЛ - ОБРАБОТАТЬ ЗАКАЗ");
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

                                case ConsoleKey.Spacebar:
                                    ProductManipulation.BuyOrPerformAdmin();//пробел выполнить
                                    break;
                                case ConsoleKey.Escape:
                                    return;
                                /*case ConsoleKey.Enter:
                                return;*/ //           повесим выполнение покупки

                            }

                            break;
                        case 2:
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

                            break;
                    }

                    
                }
                else
                {
                    if (TopMenu.CounterTopMenu == 0)
                    {
                        Console.WriteLine("ENTER - ДОБАВИТЬ ПРОДУКТ В КОРЗИНУ");
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
                            case ConsoleKey.Enter:
                                ProductManipulation.AddInCart();
                                break;


                        }
                    }
                    else if (TopMenu.CounterTopMenu == 1)
                    {
                        Console.WriteLine("ПРОБЕЛ - ЗАКАЗАТЬ....DELETE - УДАЛИТЬ");
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

                            case ConsoleKey.Delete:
                                ProductManipulation.DeleteFromCart();
                                break;
                            case ConsoleKey.Escape:
                                return;
                            case ConsoleKey.Spacebar:
                                ProductManipulation.BuyOrPerform();//пробел выполнить
                                break;


                        }
                    }
                    else if (TopMenu.CounterTopMenu == 2)
                    {
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
                            


                        }
                    }

                }

            }
        }
    }
}
