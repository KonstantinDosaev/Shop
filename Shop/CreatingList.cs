namespace Shop
{
    internal class CreatingList
    {
        
        public static void AddProduct()
        {
            var addObj = new Product() ;
          switch (VerticalMenu.CounterProductVertical)
          {
              case 0:  addObj = new VideoCard(); break;
              case 1:  addObj = new HardDrive(); break;
          }

          addObj.FillProduct();

          var priceList = Serialization.DeSerializationStrings();

          priceList.Add(addObj);

          Serialization.SerializationString(priceList);
          
        }




    }
}
