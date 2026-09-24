using System;

namespace OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        // --- PEDIDO 1 (EUA) ---
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.50, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P102", 75.00, 1));
        order1.AddProduct(new Product("USB-C Cable", "P103", 9.99, 3));

        // --- PEDIDO 2 (Internacional - Portugal) ---
        Address address2 = new Address("Av. da Liberdade 200", "Lisboa", "Lisboa", "Portugal");
        Customer customer2 = new Customer("Maria Silva", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Ergonomic Chair", "P201", 180.00, 1));
        order2.AddProduct(new Product("Desk Mat", "P202", 15.00, 2));

        // --- EXIBIÇÃO DOS PEDIDOS ---
        Console.WriteLine("========================================");
        Console.WriteLine("              ORDER #1                  ");
        Console.WriteLine("========================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}\n");

        Console.WriteLine("========================================");
        Console.WriteLine("              ORDER #2                  ");
        Console.WriteLine("========================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}\n");
    }
}