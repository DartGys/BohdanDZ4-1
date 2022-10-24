namespace BohdanDZ4_1
{
    public class Item
    {
        public int ItemId;
        public int Price;
        public string Origin;
        public string Name;
        public string Date;
        public string Description;
        public Item(int itemId, int price, string origin, string name, string date, string description)
        {
            this.ItemId = itemId;
            this.Price = price;
            this.Origin = origin;
            this.Name = name;
            this.Date = date;
            this.Description = description;
        }
    }

    public class Book : Item
    {
        public int pages;
        public string publisher;
        public List<string> authors;
        public Book(int itemId, string name, int pages, string publisher, List<string> authors, int price, string origin, string date, string description) : base(itemId, price, origin, name, date, description)
        {
            this.pages = pages;
            this.publisher = publisher;
            this.authors = authors;
        }
    }
    public class Products : Item
    {
        public string valid;
        public int quantity;
        public string unit;
        public Products(int itemId, string name, int price, string origin, int quantity, string unit, string date, string valid, string description) : base(itemId, price, origin, name, date, description)
        {
            this.valid = valid;
            this.quantity = quantity;
            this.unit = unit;
        }
    }
}