using Newtonsoft.Json;
using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Shop
{
    class Program
    {


        static void Main(string[] args)
        {
            //VideoCard nvid = new VideoCard("Видеокрта", "nVidia", "1660", 6, "Pcie3", 5, 55);
            //VideoCard rad = new VideoCard("Видеокрта", "AMD", "3060", 8, "Pcie4", 66, 444);
            //HardDrive kingst = new HardDrive("Жесткий диск", "Kingston", "ff222", 512, 7600, 445, 554);
            //HardDrive kings11t = new HardDrive("Жесткий диск", "Kingston1111", "ff222222222", 512, 7600, 445, 554);
            //List<Product> price = new List<Product> { nvid, kingst, rad, kings11t };
            //Serialization.SerializationString(price);


            Included.IncludedInProgram();


            //CreatingList.AddProduct();

            while (true)
            {

                //List<string> cartList = Serialization.DeSerializationCart();

                //List<string> history;
                //if (Included.NameUser == "admin")
                //{
                //    history = Serialization.DeSerializationHistoryAdmin();
                //}
                //else { history = Serialization.DeSerializationHistory();}

                TopMenu.LaunchTopMenu();

                if (TopMenu.CounterTopMenu == 0)
                {
                    var priceList = Serialization.DeSerializationStrings();
                    PriceList.LaunchPrice(priceList);
                }
                else if (TopMenu.CounterTopMenu == 1)
                {
                    var cartList = Serialization.DeSerializationStrings(Included.NameUser, "cart");
                    PriceList.LaunchPrice(cartList);
                }
                else if (TopMenu.CounterTopMenu == 2)
                {
                    var history = Serialization.DeSerializationStrings(Included.NameUser, "history");
                    PriceList.LaunchPrice(history);
                }
            }






        }

        
    }
}
