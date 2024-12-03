using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        
        Address address1 = new Address("123 Elm Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Address address2 = new Address("456 Maple Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        
        Product product1 = new Product("Laptop", "P001", 1200, 1);
        Product product2 = new Product("Mouse", "P002", 25, 2);
        Product product3 = new Product("Keyboard", "P003", 50, 1);

        Product product4 = new Product("Monitor", "P004", 300, 1);
        Product product5 = new Product("USB Cable", "P005", 10, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
        
    }
}