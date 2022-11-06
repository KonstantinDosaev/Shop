using System.Reflection;

namespace Shop
{
    
    internal class VideoCard : Product
    {
        public VideoCard(string? typeProduct, string? manufacture, string? model, float purchasePrice, float salePrice, float videoMemory, string? connectionInterface) : 
            base( typeProduct,  manufacture,  model,  purchasePrice, salePrice)
        {
            VideoMemory = videoMemory;
            ConnectionInterface = connectionInterface;
        }

        public VideoCard() {}

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
            TypeProduct = "Видеокарта";
            base.FillProduct();

            Console.WriteLine("Графическая память:");
            VideoMemory = ProductManipulation.CheckingNumbers();

            Console.WriteLine("Интерфейс подключения:");
            ConnectionInterface = Console.ReadLine();

        }
    }


}
