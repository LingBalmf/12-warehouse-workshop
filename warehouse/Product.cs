namespace Warehouse {
    public class Product {
        public string Id { get; }
        public string Name { get; }
        public double Price { get; }

        public Product(string id, string name, double price) {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}