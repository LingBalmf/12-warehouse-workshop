namespace Warehouse
{
	class Inventory
    {
        public string Name {get; set;}
        public List<Stock> StockList {get; set;}

        public Inventory  (string name)
        {
            Name = name;
            StockList = new List<Stock>();
        }

        public void SetStock(Product product, int quantity, int reorderLevel) //set up initial list
        {
            StockList.Add(new Stock(product, quantity, reorderLevel));
        }


        public void PrintInventory()
        {
            Console.WriteLine("Inventory of warehouse:");
            foreach(Stock stockItem in StockList)
            {   
                string lowStock = ""; 
                if (stockItem.Quantity <= stockItem.ReorderLevel) {
                    lowStock = "** LOW STOCK**" ;
                }
                Console.WriteLine($"    {stockItem.Product.Name}: {stockItem.Quantity}: Reorder Level: {stockItem.ReorderLevel}  {lowStock}");
            }
        }
	}

}



