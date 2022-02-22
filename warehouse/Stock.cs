namespace Warehouse
{
	public class Stock
	{
            public Product Product { get; }
            public int Quantity { get; set; }

            public int ReorderLevel { get; set; }

            public Stock(Product product, int quantity, int reorderLevel = 10)
            {
                Product = product;
                Quantity = quantity;
                ReorderLevel = reorderLevel;
            }

            public void Add(int quantity) {
                Quantity += quantity;
            }

            public void Remove(int quantity) {
                Quantity -= quantity;
            }

	}

}