using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class CreatingList
    {
        public static void AddProduct()
        {
            Console.WriteLine("Тип продукта:");
            string? typ = Console.ReadLine();

            Console.WriteLine("Производитель:");
            string? manufacture = Console.ReadLine();

            Console.WriteLine("Модель:");
            string? model = Console.ReadLine();

            Console.WriteLine("Графическая память:");
            float videoMemory = float.Parse(Console.ReadLine());

            Console.WriteLine("Интерфейс подключения:");
            string? interfaceConn = Console.ReadLine();

            Console.WriteLine("Закупочная цена:");
            float purchase = float.Parse(Console.ReadLine());

            Console.WriteLine("Цена продажи:");
            float sale = float.Parse(Console.ReadLine());



            VideoCard addObj = new VideoCard(typ, manufacture, model, videoMemory, interfaceConn, purchase, sale);

            string addString = BulledString(addObj);


            List<string> priceList = Serialization.DeSerializationStrings();

            priceList.Add(addString);

            Serialization.SerializationString(priceList);

        }



        public static string BulledString(VideoCard prod)
        {
            string element = $"\t{prod.TypeProduct}\n" +
                             $"\tПроизводитель : {prod.Manufacture}\n" +
                             $"\tМодель : {prod.Model}\n" +
                             $"\tГрафическая память: {prod.VideoMemory} ГБ\n" +
                             $"\tИнтерфейс подключения: {prod.ConnectionInterface}\n" +
                             $"\tЦена закупки : {Convert.ToString(prod.PurchasePrice)}\n" +
                             $"\tЦена продажи : {Convert.ToString(prod.SalePrice)}";
            return element;
        }
        public static string BulledString(HardDrive prod)
        {
            string element = $"\t{prod.TypeProduct}\n" +
                             $"\tПроизводитель : {prod.Manufacture}\n" +
                             $"\tМодель : {prod.Model}\n" +
                             $"\tГрафическая память: {prod.MemoryCapacity} ГБ\n" +
                             $"\tИнтерфейс подключения: {prod.RotationSpeed} об/мин\n" +
                             $"\tЦена закупки : {Convert.ToString(prod.PurchasePrice)}\n" +
                             $"\tЦена продажи : {Convert.ToString(prod.SalePrice)}";
            return element;
        }
    }
}
