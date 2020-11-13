namespace Tasks.HelpClasses
{
    public class Product
    {
        public Product(int id, string name, Stock stock)
        {
            Id = id;
            Name = name;
            Stock = stock;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Stock Stock { get; set; }
    }
}
