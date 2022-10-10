using Newtonsoft.Json;
using System;
using System.Collections;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Shop
{
    class Program
    {


        static void Main(string[] args)
        {

            Included.IncludedInProgram();
           
           

            while (true)
            {

                
                    List<string> priceList = Serialization.DeSerializationStrings();

                List<string> cartList = Serialization.DeSerializationCart();

                List<string> history;
                if (Included.NameUser == "admin")
                {
                    history = Serialization.DeSerializationHistoryAdmin();
                }
                else { history = Serialization.DeSerializationHistory();}

                TopMenu.LaunchMenu();
                if (TopMenu.CounterTopMenu == 0)
                {
                    PriceList.LaunchPrice(priceList);
                }
                else if (TopMenu.CounterTopMenu == 1)
                {
                    PriceList.LaunchPrice(cartList);
                }
                else if (TopMenu.CounterTopMenu == 2)
                {
                    PriceList.LaunchPrice(history);
                }
            }



            


        }

        
    }
}
