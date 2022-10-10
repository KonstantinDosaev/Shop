using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Product
    {
        //private object advancedProperty;

        public string? TypeProduct { get; set; }

        public string? Manufacture { get; set; }

        public string? Model { get; set; }
        public float PurchasePrice { get; set; }
        public float SalePrice { get; set; }

        public Product(string typeProduct, string manufacture, string model, float purchasePrice, float salePrice)
        {
            TypeProduct = typeProduct;
            Manufacture = manufacture;
            Model = model;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
        }

        //public string BulledString()
        //{
        //    if (TypeProduct == "Видеокарта")
        //    {
        //         advancedProperty = $"Графическая память: {VideoMemory} ГБ\n\tИнтерфейс подключения: {ConnectionInterface}";
        //    }
        //    string element = $"\t{TypeProduct}\n\tПроизводитель : {Manufacture}\n\tМодель : {Model}\n\t{advancedProperty}\n\tЦена закупки : {Convert.ToString(PurchasePrice)}\n\tЦена продажи : {Convert.ToString(SalePrice)}";
        //    return element;
        //}
        
    }
    internal class VideoCard : Product
    {
        public VideoCard(string typeProduct, string manufacture, string model,float videoMemory, string connectionInterface, float purchasePrice, float salePrice) : base(typeProduct, manufacture, model, purchasePrice, salePrice)
        {
            VideoMemory = videoMemory;
            ConnectionInterface = connectionInterface;
        }

        public float VideoMemory { get; set; }
        public string? ConnectionInterface { get; set; }


    }

    internal class HardDrive : Product
    {
        public HardDrive(string typeProduct, string manufacture, string model,float memoryCapacity, float rotationSpeed, float purchasePrice, float salePrice) : base(typeProduct, manufacture, model, purchasePrice, salePrice)
        {
        }

        public float MemoryCapacity { get; set; }
        public float RotationSpeed { get; set; }


    }

}
