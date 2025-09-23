using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // First Order: Customer from the USA
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Laptop", "LP01", 1200.00, 1));
        products1.Add(new Product("Mouse", "M01", 25.50, 2));

        Order order1 = new Order(products1, customer1);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine("------------------------------");

        // Second Order: Customer from outside the USA
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);

        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Keyboard", "KB02", 75.00, 1));
        products2.Add(new Product("Monitor", "MO03", 250.00, 1));
        products2.Add(new Product("Webcam", "WC04", 45.00, 1));
        
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}