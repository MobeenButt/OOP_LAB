using System;

namespace Book
{
    internal class book
    {
        public string title;
        public string[] authors;//= new string[4];
        public string publisher;
        public string ISBN;
        public double price;
        public int stock;
       
        public book()
        {
            ///DEFAULT Constructor
        }
        public book(string title, string[] authors, string publisher, string ISBN, double price, int stock)
        {
            this.title = title;
            this.authors = authors;
            this.publisher = publisher;
            this.ISBN = ISBN;
            this.price = price;
            this.stock = stock;
       
        }
        public string Title()
        {
            return title;
        }
        public void SETtitle(string title)
        {
            this.title=title;
        }
        public bool SimilarTitle(string newTitle)
        {

            if (title.Length != newTitle.Length)
            {

                return false;
            }
            return true;
        }
        public void Stock()
        {
            Console.WriteLine("Stock: " + stock);
        }
        public void SetStock(int newstock)
        {
            stock = stock + newstock;
        }
        public void UpdateStock(int quantity)
        {
            stock=stock + quantity;
        }
        public string[] GetAuthors()
        {
            return authors;
        }
        public  void setAuthors(string[] authors)
        {
            this.authors=authors;
        
        }
        public string GetPublisher()
        {
            return publisher;
        }
        public void SETPublisher(string publisher)
        {
            this.publisher = publisher;
        }
        public string GetISBN()
        {
            return ISBN;
        }

        public void SetISBN(string ISBN)
        {
            this.ISBN = ISBN;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public int GetStock()
        {
            return stock;
        }
    }
}
