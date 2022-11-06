namespace Shop
{

    public class Product
    {
        public Product(string? typeProduct, string? manufacture, string? model, float purchasePrice, float salePrice)
        {
            TypeProduct = typeProduct;
            Manufacture = manufacture;
            Model = model;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
        }

        public Product() { }

        public string? TypeProduct { get; set; }

        public string? Manufacture { get; set; }

        public string? Model { get; set; }
        public float PurchasePrice { get; set; }
        public float SalePrice { get; set; }

        public virtual void PrintProduct()
        {
            Console.WriteLine($"\t{TypeProduct}\n" +
                              $"\tПроизводитель : {Manufacture}\n" +
                              $"\tМодель : {Model}");
        }

        public void PrintPrice()
        {
            Console.WriteLine($"\tЦена закупки : {PurchasePrice}\n" +
                              $"\tЦена продажи : {SalePrice}\n");
        }

        public virtual void FillProduct()
        {
            Console.WriteLine("Производитель:");
            Manufacture = Console.ReadLine();

            Console.WriteLine("Модель:");
            Model = Console.ReadLine();

            Console.WriteLine("Закупочная цена:");
            PurchasePrice = ProductManipulation.CheckingNumbers();

            Console.WriteLine("Цена продажи:");
            SalePrice = ProductManipulation.CheckingNumbers();
        }




    }
}