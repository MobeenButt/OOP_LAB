namespace Store
{
    internal class Product
    {
       public string name;
       public string cateogry;
       public double price;
       public double stock;
       public double minimumstock;
       
        public Product(string name, string category, double price, double stock, double minimumstock)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stock = stock;
            this.minimumstock = minimumstock;
        }

        public string ViewProduct()
        {
            return name + " " + category + " " + price + " " + stock + " " + minimumstock;
        }

        public double PriceAfterTax()
        {
            if (category == "Grocery")
            {
                return price = price - (price * 10 / 100);
            }
            else if (category == "Fruits")

            {
                return price = price - (price * 5 / 100);
            }
            else
            {
                return price = price - (price * 15 / 100);
            }
        }
    }
}
