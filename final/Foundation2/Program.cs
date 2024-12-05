using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", "L001", 1000.00m, 1);
        Product product2 = new Product("Mouse", "M001", 25.00m, 2);
        Product product3 = new Product("Keyboard", "K001", 50.00m, 1);
        Product product4 = new Product("Monitor", "M002", 200.00m, 1);
        Product product5 = new Product("Desk Lamp", "D001", 45.00m, 1);

        // Create orders and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }
    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
        Console.WriteLine();
    }
}
