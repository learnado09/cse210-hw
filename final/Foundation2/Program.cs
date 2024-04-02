using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("166 N 5th W", "Rexburg", "ID", "USA");
        Address nonUsaAddress = new Address("W05 bole ", "Nairobi", "Nairobi", "Kenya");


        Customer usCustomer = new Customer("David", usaAddress);
        Customer nonUsCustomer = new Customer("Leonard", nonUsaAddress);

        
        Product product1 = new Product("IPhone 15", "IPH15", 1100, 2);
        Product product2 = new Product("Samsung", "PRO121", 1200, 1);

        
        List<Product> order1Products = new List<Product> { product1, product2 };
        Order order1 = new Order(usCustomer, order1Products);

        List<Product> order2Products = new List<Product> { product1, product2 };
        Order order2 = new Order(nonUsCustomer, order2Products);

        Console.WriteLine("Order 1:");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}
    