using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress =
            new Address(
                "123 Main St",
                "New York",
                "NY",
                "USA");

        Customer customer1 =
            new Customer(
                "John Smith",
                usaAddress);

        Order order1 =
            new Order(customer1);

        order1.AddProduct(
            new Product(
                "Laptop",
                "P100",
                900,
                1));

        order1.AddProduct(
            new Product(
                "Mouse",
                "P101",
                25,
                2));

        Address internationalAddress =
            new Address(
                "Av. Amazonas",
                "Quito",
                "Pichincha",
                "Ecuador");

        Customer customer2 =
            new Customer(
                "Stephano Martinez",
                internationalAddress);

        Order order2 =
            new Order(customer2);

        order2.AddProduct(
            new Product(
                "Keyboard",
                "P200",
                60,
                1));

        order2.AddProduct(
            new Product(
                "Monitor",
                "P201",
                250,
                2));

        Console.WriteLine("ORDER 1");
        Console.WriteLine("----------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine(
            $"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine("----------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine(
            $"Total Cost: ${order2.CalculateTotalCost()}");
    }
}