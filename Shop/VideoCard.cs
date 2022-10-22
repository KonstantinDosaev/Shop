namespace Shop
{
    [Serializable]
    internal class VideoCard : Product
    {
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
            VideoMemory = float.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Интерфейс подключения:");
             ConnectionInterface = Console.ReadLine();

        }
    }


}
