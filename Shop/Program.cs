using Shop;




Included.IncludedInProgram();

while (true)
{
    TopMenu.LaunchTopMenu();

    switch (TopMenu.CounterTopMenu)
    {
        case 0:
        {
            var priceList = Serialization.DeSerializationStrings();
            PriceList.LaunchPrice(priceList);
            break;
        }
        case 1:
        {
            var cartList = Serialization.DeSerializationStrings(Included.NameUser, "cart");
            PriceList.LaunchPrice(cartList);
            break;
        }
        case 2:
        {
            var history = Serialization.DeSerializationStrings(Included.NameUser, "history");
            PriceList.LaunchPrice(history);
            break;
        }
    }
}