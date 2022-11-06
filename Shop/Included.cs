using Newtonsoft.Json;

namespace Shop
{
    internal class Included
    {
        public static string? NameUser ;

        public static void IncludedInProgram()
        {
            Console.WriteLine("Для достуба в учетнкю запись администратора введите :   admin\n");
            Console.WriteLine("Введите ваше имя:");
            NameUser = Console.ReadLine();


            if (!File.Exists($@"jsonSave\PriceList.json"))
            {
                VideoCard nvid = new VideoCard("Видеокрта", "nVidia", "1660", 600, 22, 5, "Pcie3");
                VideoCard rad = new VideoCard("Видеокрта", "AMD", "3060", 8, 666, 66, "Pcie4");
                HardDrive kingst = new HardDrive("Жесткий диск", "Kingston", "ff222", 512, 7600, 445, 554);
                HardDrive kings11t = new HardDrive("Жесткий диск", "Kingston1111", "ff222222222", 512, 7600, 445, 554);
                List<Product> price = new List<Product> { nvid, kingst, rad, kings11t };
                Serialization.SerializationString(price);
            }


        }
    }
}
