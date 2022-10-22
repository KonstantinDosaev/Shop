namespace Shop
{
    internal class TopMenu
    {

        public static int CounterTopMenu;
        public static string TopMenuElement2 = "КОРЗИНА";
        public static string TopMenuElement3 = "ЗАКАЗЫВАЛИ РАНЕЕ";
        public static  void LaunchTopMenu()
        {
            if (Included.NameUser == "admin")
            {
                TopMenuElement2 = "ЛИСТ ОЖИДАНИЯ";
                TopMenuElement3 = "ВЫПОЛНЕННЫЕ ЗАКАЗЫ";
            }
            
            string[] topMenu = { "ПРАЙСЛИСТ", TopMenuElement2, TopMenuElement3 };
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
