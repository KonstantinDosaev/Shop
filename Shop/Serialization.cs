using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Serialization
    {
        public string User = Included.NameUser;
        public static void SerializationString(List< string> priceListArr)
        {
            //ввод в JSON
            priceListArr.Remove("Данные отсутствуют");
            var personJson = JsonConvert.SerializeObject(priceListArr);
            StreamWriter file = File.CreateText("person.json");
            file.WriteLine(personJson);
            file.Close();



        }
        public static void SerializationCart(List<string> priceListArr)
        {
            //ввод в JSON
            priceListArr.Remove("Данные отсутствуют");
            var personJson = JsonConvert.SerializeObject(priceListArr);
            StreamWriter file = File.CreateText($"{Included.NameUser}cart.json");
            file.WriteLine(personJson);
            file.Close();



        }
        public static void SerializationHystory(List<string> priceListArr)
        {
            //ввод в JSON
            priceListArr.Remove("Данные отсутствуют");
            var personJson = JsonConvert.SerializeObject(priceListArr);
            StreamWriter file = File.CreateText($"{Included.NameUser}hystory.json");
            file.WriteLine(personJson);
            file.Close();



        }
        public static void SerializationHystoryAdmin(List<string> priceListArr)
        {
            //ввод в JSON
            priceListArr.Remove("Данные отсутствуют");
            var personJson = JsonConvert.SerializeObject(priceListArr);
            StreamWriter file = File.CreateText($"adminhystory.json");
            file.WriteLine(personJson);
            file.Close();



        }

        public static void SerializationCartAdmin(List<string> priceListArr)
        {
            //ввод в JSON
            
                priceListArr.Remove("Данные отсутствуют");
            
            var personJson = JsonConvert.SerializeObject(priceListArr);
            StreamWriter file = File.CreateText($"admincart.json");
            file.WriteLine(personJson);
            file.Close();



        }

        public static List<string> DeSerializationCart()
        {
            //вывод из JSON

            if (File.Exists($"{Included.NameUser}cart.json"))
            {
                string data = File.ReadAllText($"{Included.NameUser}cart.json");

                List<string> person = JsonConvert.DeserializeObject<List<string>>(data);

                return person;
            }
            else
            {
                List<string> f = new List<string>() { "Данные отсутствуют" };
                return f;
            }
        }

        public static List<string> DeSerializationHistory()
        {
            //вывод из JSON

            if (File.Exists($"{Included.NameUser}hystory.json"))
            {
                string data = File.ReadAllText($"{Included.NameUser}hystory.json");

                List<string> person = JsonConvert.DeserializeObject<List<string>>(data);

                return person;
            }
            else
            {
                List<string> f = new List<string>() { "Данные отсутствуют" };
                return f;
            }
        }
        public static List<string> DeSerializationHistoryAdmin()
        {
            //вывод из JSON

            if (File.Exists($"adminhystory.json"))
            {
                string data = File.ReadAllText($"adminhystory.json");

                List<string> person = JsonConvert.DeserializeObject<List<string>>(data);

                return person;
            }
            else
            {
                List<string> f = new List<string>() { "Данные отсутствуют" };
                return f;
            }
        }
        public static List<string> DeSerializationCartAdmin()
        {
            //вывод из JSON

            if (File.Exists($"admincart.json"))
            {
                string data = File.ReadAllText($"admincart.json");

                List<string> person = JsonConvert.DeserializeObject<List<string>>(data);

                return person;
            }
            else
            {
                List<string> f = new List<string>() { "Данные отсутствуют" };
                return f;
            }
        }
        public static List<string> DeSerializationStrings()
        {
            //вывод из JSON

            if (File.Exists("person.json"))
            {
                string data = File.ReadAllText("person.json");

                List <string> person = JsonConvert.DeserializeObject<List<string>>(data);

                return person;
            }
            else
            {
                List<string> f = new List<string>() { "Данные отсутствуют" };
                return f;
            }
        }
    }
}
