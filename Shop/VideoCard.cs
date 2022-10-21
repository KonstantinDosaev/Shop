using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    [Serializable]
    internal class VideoCard : Product
    {
        public VideoCard(string typeProduct, string manufacture, string model, float videoMemory, string connectionInterface, float purchasePrice, float salePrice) : base(typeProduct, manufacture, model, purchasePrice, salePrice)
        {
            
            VideoMemory = videoMemory;
            ConnectionInterface = connectionInterface;

        }
        public VideoCard() { }
        public new string TypeProduct = "Видеокарта";

        public float VideoMemory { get; set; }
        public string? ConnectionInterface { get; set; }

        public override void PrintProduct()
        {
            base.PrintProduct();
            Console.WriteLine($"\tГрафическая память: {VideoMemory} ГБ\n" +
                              $"\tИнтерфейс подключения : {ConnectionInterface}");
            PrintPrice();

            
        }

        public override void FillProduct()
        {

            base.FillProduct();
            Console.WriteLine("Графическая память:");
            VideoMemory = float.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Интерфейс подключения:");
             ConnectionInterface = Console.ReadLine();

        }
    }


}
