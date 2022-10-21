//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Serialization
    {
      public static void SerializationString(List<Product> priceListArr)
        {
            //priceListArr.Remove("Данные отсутствуют");

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(@"C:\Users\Константин\source\repos\Shop\Shop\bin\Debug\net6.0\jsonSave\PriceState.dat", FileMode.Create))
            {
                formatter.Serialize(stream, priceListArr);
            }
        }
        public static void SerializationString(List<Product> priceListArr,string name, string fillName)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream($@"C:\Users\Константин\source\repos\Shop\Shop\bin\Debug\net6.0\jsonSave\{name}{ fillName}.dat", FileMode.Create))
            {
                formatter.Serialize(stream, priceListArr);
                
            }
        }


        public static List<Product> DeSerializationStrings()
        {
            if (File.Exists($@"C:\Users\Константин\source\repos\Shop\Shop\bin\Debug\net6.0\jsonSave\PriceState.dat"))
            {

                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream stream = new FileStream(@"C:\Users\Константин\source\repos\Shop\Shop\bin\Debug\net6.0\jsonSave\PriceState.dat", FileMode.Open))
                {
                    List<Product> priceListArr = (List<Product>)formatter.Deserialize(stream);
                   return priceListArr;
                }


            }
            else
            {
                List<Product> f = new List<Product>();
                return f;
            }
        }
        public static List<Product> DeSerializationStrings(string name,string fillName)
        {
            if (File.Exists($@"C:\Users\Константин\source\repos\Shop\Shop\bin\Debug\net6.0\jsonSave\{name}{fillName}.dat"))
            {

                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream stream = new FileStream($@"C:\Users\Константин\source\repos\Shop\Shop\bin\Debug\net6.0\jsonSave\{name}{fillName}.dat", FileMode.Open))
                {
                    List<Product> priceListArr = (List<Product>)formatter.Deserialize(stream);
                    return priceListArr;
                }


            }
            else
            {
                List<Product> f = new List<Product>();
                return f;
            }
        }
    }
}
