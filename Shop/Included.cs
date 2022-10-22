namespace Shop
{
    internal class Included
    {
        public static string? NameUser = " ";

        public static void IncludedInProgram()
        {
            Console.WriteLine("Введите ваше имя:");
            string? nameUser = Console.ReadLine();
            NameUser = nameUser;

 
        }
    }
}
