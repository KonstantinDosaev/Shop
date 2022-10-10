using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class ProductManipulation
    {
        public static void DeleteProduct()
        {
            List<string> priceList = Serialization.DeSerializationStrings();

            for (var i = 0; i < priceList.Count; i++)
            {
                if (PriceList.CounterProductIner == i)
                {
                    priceList.RemoveAt(i);
                }
            }

            Serialization.SerializationString(priceList);

        }
        public static void AddInCart()
        {
            List<string> priceList = Serialization.DeSerializationStrings();
            List<string> cartList = Serialization.DeSerializationCart();

            for (var i = 0; i < priceList.Count; i++)
            {
                if (PriceList.CounterProductIner == i)
                {
                    cartList.Add(priceList[i]);
                }


            }

            Serialization.SerializationCart(cartList);

        }
        public static void BuyOrPerform()
        {
            List<string> historyList = Serialization.DeSerializationHistory();
            List<string> cartList = Serialization.DeSerializationCart();
            List<string> adminList = Serialization.DeSerializationCartAdmin();


                historyList.AddRange(cartList);
                adminList.AddRange(cartList);
                cartList = new List<string>();


            Serialization.SerializationHystory(historyList);
            Serialization.SerializationCart(cartList);
            Serialization.SerializationCartAdmin(adminList);


        }
        public static void BuyOrPerformAdmin()
        {
            List<string> historyList = Serialization.DeSerializationHistoryAdmin();

            List<string> adminList = Serialization.DeSerializationCartAdmin();


            historyList.AddRange(adminList);
            
            adminList = new List<string>();


            Serialization.SerializationHystoryAdmin(historyList);
 
            Serialization.SerializationCartAdmin(adminList);


        }


        public static void DeleteFromCart()
        {
            List<string> priceList = Serialization.DeSerializationCart();

            for (var i = 0; i < priceList.Count; i++)
            {
                if (PriceList.CounterProductIner == i)
                {
                    priceList.RemoveAt(i);
                }
            }

            Serialization.SerializationCart(priceList);

        }
    }
}
