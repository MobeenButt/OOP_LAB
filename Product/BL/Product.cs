using System.Collections.Generic;
namespace Product
{
 public  class Product
    {
        public string name;
        public string category;
        public int price;
        public int stock;
        public int minimumstock;

        public Product(string name, string category, int price, int stock, int minimumstock)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stock = stock;
            this.minimumstock = minimumstock;
        }
        public int CalTax()
        {
            int price = 0;
            if (category == "Fruits")
            {
                price = price - (price * 5 / 100);
            }
            else if (category == "Grocery")
            {
                price -= (price * 10 / 100);
            }
            else
            {
                price = price - (price * 15 / 100);
            }
            return price;
        }
       public bool RecordNeed()
        {
            if (stock <= minimumstock)
            {
                return true;
            }
            return false;
        }
        public string DisplayProduct()
        {
            return $"{name},{category},{price},{stock},{minimumstock}";
        }
    }
}
