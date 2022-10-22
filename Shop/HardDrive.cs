using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    [Serializable]
    internal class HardDrive : Product
    {
        public float MemoryCapacity { get; set; }
        public float RotationSpeed { get; set; }

        public override void PrintProduct()
        {
            base.PrintProduct();
            Console.WriteLine($"\tОбъем памяти: {MemoryCapacity} ГБ\n" +
                              $"\tСкорость вращения: {RotationSpeed} об.мин");
           PrintPrice();
        }
        public override void FillProduct()
        {
            TypeProduct = "Жесткий диск";
            base.FillProduct();

            Console.WriteLine("Объем памяти:");
            MemoryCapacity = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Скорость вращения:");
            RotationSpeed = float.Parse(Console.ReadLine()!);
        }
    }
}
