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
            var priceList = Serialization.DeSerializationStrings();

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
            var priceList = Serialization.DeSerializationStrings();
            var cartList = Serialization.DeSerializationStrings(Included.NameUser,"cart");

            for (var i = 0; i < priceList.Count; i++)
            {
                if (PriceList.CounterProductIner == i)
                {
                    cartList.Add(priceList[i]);
                }

            }

            Serialization.SerializationString(cartList, Included.NameUser, "cart");

        }
        public static void BuyOrPerform()
        {
            var historyList = Serialization.DeSerializationStrings(Included.NameUser, "history");
            var cartList = Serialization.DeSerializationStrings(Included.NameUser, "cart");
            var adminList = Serialization.DeSerializationStrings("admin", "cart");


            historyList.AddRange(cartList);
            adminList.AddRange(cartList);
            cartList = new List<Product>();


            Serialization.SerializationString(historyList, Included.NameUser, "history");
            Serialization.SerializationString(cartList, Included.NameUser, "cart");
            Serialization.SerializationString(adminList, "admin", "cart");


        }
        public static void BuyOrPerformAdmin()
        {
            var historyList = Serialization.DeSerializationStrings(Included.NameUser, "history");

            var adminList = Serialization.DeSerializationStrings(Included.NameUser, "cart");


            historyList.AddRange(adminList);

            adminList = new List<Product>();


            Serialization.SerializationString(historyList, Included.NameUser, "history");

            Serialization.SerializationString(adminList, Included.NameUser, "cart");


        }


        public static void DeleteFromCart()
        {
            var priceList = Serialization.DeSerializationStrings(Included.NameUser, "cart");

            for (var i = 0; i < priceList.Count; i++)
            {
                if (PriceList.CounterProductIner == i)
                {
                    priceList.RemoveAt(i);
                }
            }

            Serialization.SerializationString(priceList, Included.NameUser, "cart");

        }
    }
}
