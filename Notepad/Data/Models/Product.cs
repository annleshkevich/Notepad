namespace Notepad.Data.Models
{
    public class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public DateTime? date { get; set; }
        public Product(string name, double price, DateTime? date)
        {
            this.name = name;
            this.price = price;
            this.date = date;
        }
    }
}
