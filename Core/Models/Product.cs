namespace AWE_Electronics.Core.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        //Constructor
        public Product(string name, string description, int price, int stock)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }

        //Methods
        public override string ToString() //Overriding the ToString function to display Product Info
        {
            return $"{Name} - {Description} - ${Price}";
        }

    }
}
