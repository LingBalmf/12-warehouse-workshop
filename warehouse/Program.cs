using System;

namespace Warehouse
{
	public class Program
	{
		static void Main(string[] args)
		{
            Inventory warehouse1 = new Inventory("Asda");
            
            Product milk = new Product("001", "Milk", 1.30);
            Product bread = new Product("002", "Bread", 1.00);
            Product coffee = new Product("003", "Coffee", 4.99);

            warehouse1.SetStock(milk, 10, 12);
            warehouse1.SetStock(coffee, 25, 2);

    
            warehouse1.PrintInventory();

		}
	} 

}
