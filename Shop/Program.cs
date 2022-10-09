using Newtonsoft.Json;
using System;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Shop
{
    class Program
    {


        static void Main(string[] args)
        {
            //Product radeon = new Product("Видеокарта", "ATI Radeon", "3060TI", 6000, 12000);
            //string radeon3060 = radeon.BulledArray();
            //Product nVidia = new Product("Видеокарта", "NVIDIA", "GeForce 1660", 5000, 10000);
            //string nVidia1660 = nVidia.BulledArray();
            //Product kingstonHdd = new Product("Жесткий диск", "Kingston", "HDD762", 2000, 6000);
            //string kingston762 = kingstonHdd.BulledArray();




            //List<string> priceListArr = new List<string>() { radeon3060, nVidia1660 };




            //var personJson = JsonConvert.SerializeObject(priceListArr);
            //StreamWriter file = File.CreateText("person.json");
            //file.WriteLine(personJson);
            //file.Close();
            //if (File.Exists("person.json"))
            //{
            //    string data = File.ReadAllText("person.json");

            //    string[]? person = JsonConvert.DeserializeObject<string[]>(data);
            //    pr = person;


            //}
            string data = File.ReadAllText("person.json");

            string[]? person = JsonConvert.DeserializeObject<string[]>(data);
            string[] pr66 = person;
            Console.WriteLine(pr66[1]);



        }

        static string[] Per(string[] priceListArr)
        {
            // ввод в JSON
            //string[] pr66;
            //var personJson = JsonConvert.SerializeObject(priceListArr);
            //StreamWriter file = File.CreateText("person.json");
            //file.WriteLine(personJson);
            //file.Close();

            //вывод из JSON
            if (File.Exists("person.json"))
            {
                string data = File.ReadAllText("person.json");

                string[]? person = JsonConvert.DeserializeObject<string[]>(data);
                
                return person;
            }
            else
            {
                string[] f = {"Данные отсутствуют" };
                return f;
            }
        }
    }
}
