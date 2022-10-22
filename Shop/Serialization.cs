using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Shop
{
    internal class Serialization
    {
        private static JsonSerializerSettings TypSettings()
        {
            var js = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            return js;
        }

        public static void SerializationString(List<Product> priceListArr)
        {
          var jsonString = JsonConvert.SerializeObject(priceListArr, Formatting.Indented, TypSettings()); 
          
           using  var file = File.CreateText(@"jsonSave\PriceList.json");
           file.WriteLine(jsonString);
        }

        public static void SerializationString(List<Product> priceListArr, string? name, string fillName)
        {
            var jsonString = JsonConvert.SerializeObject(priceListArr, Formatting.Indented, TypSettings());

            using var file = File.CreateText($@"jsonSave\{name}{fillName}.json");
            file.WriteLine(jsonString);
        }

        public static List<Product> DeSerializationStrings()
        {
            if (File.Exists($@"jsonSave\PriceList.json"))
            {
                var newStockholder = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(@"jsonSave\PriceList.json"), TypSettings());
                return newStockholder ?? new List<Product>();
            }
            var fall = new List<Product>();
            return fall;
        }

        public static List<Product> DeSerializationStrings(string? name, string fillName)
        {
            if (File.Exists($@"jsonSave\{name}{fillName}.json"))
            {
                var newStockholder = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText($@"jsonSave\{name}{fillName}.json"), TypSettings());
                return newStockholder ?? new List<Product>();
            }
            var fall = new List<Product>();
            return fall;
        }
      
    }
}
