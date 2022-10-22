namespace Shop
{
    internal class PriceList
    {
        public static int CounterProductIner;

        public static void LaunchPrice(List<Product> productMenu)
        {

            string[] topMenu = { "ПРАЙСЛИСТ", TopMenu.TopMenuElement2, TopMenu.TopMenuElement3 };


            while (true)
            {
                Console.Clear();

                foreach (var element in topMenu)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"\t\t     {element}  \t\t");
                }
                Console.WriteLine("\n\n\n");

                for (var i = 0; i < productMenu.Count; i++)
                {
                    if (CounterProductIner == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        productMenu[i].PrintProduct();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        productMenu[i].PrintProduct();
                    }
                }

                Console.WriteLine("\n\n");

                if (Included.NameUser == "admin")
                {
                    switch (TopMenu.CounterTopMenu)
                    {
                        case 0: Console.WriteLine("ПРОБЕЛ - ДОБАВИТЬ ПРОДУКТ....DELETE - УДАЛИТЬ"); break;
                        case 1: Console.WriteLine("ПРОБЕЛ - ОБРАБОТАТЬ ЗАКАЗ"); break;
                    }
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
                        case ConsoleKey.Spacebar when TopMenu.CounterTopMenu == 0:
                            VerticalMenu.GetVerticalMenu();//пробел добавить
                            break;
                        case ConsoleKey.Spacebar when TopMenu.CounterTopMenu == 1:
                            ProductManipulation.BuyOrPerformAdmin();//пробел добавить
                            break;

                        case ConsoleKey.Escape:
                            return;

                    }
                   
                }
                else
                {
                    switch (TopMenu.CounterTopMenu)
                    {
                        case 0: Console.WriteLine("ENTER - ДОБАВИТЬ ПРОДУКТ В КОРЗИНУ"); break;
                        case 1: Console.WriteLine("ПРОБЕЛ - ЗАКАЗАТЬ....DELETE - УДАЛИТЬ"); break;
                    }
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
                        case ConsoleKey.Enter when TopMenu.CounterTopMenu == 0:
                            ProductManipulation.AddInCart();
                            break;

                        case ConsoleKey.Spacebar when TopMenu.CounterTopMenu == 1:
                            ProductManipulation.BuyOrPerform();//пробел выполнить заказ
                            break;
                        case ConsoleKey.Delete when TopMenu.CounterTopMenu == 1:
                            ProductManipulation.DeleteFromCart();
                            break;

                    }
                    
                }

            }
        }
    }
}
