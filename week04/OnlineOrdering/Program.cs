public class Program
{
    public static void Main(string[] args)
    {
        // --- Order 1 (USA Customer) ---
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP101", 1200.00, 1));
        order1.AddProduct(new Product("Wireless Mouse", "ACC205", 25.50, 2));
        order1.AddProduct(new Product("USB-C Hub", "ACC310", 45.00, 1));

        Console.WriteLine("----- Order 1 Details -----");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\n" + order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Order Cost: ${order1.CalculateTotalCost():0.00}");
        Console.WriteLine("---------------------------\n");

        // --- Order 2 (International Customer) ---
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("External SSD", "STR501", 150.00, 1));
        order2.AddProduct(new Product("Gaming Headset", "AUD402", 99.99, 1));

        Console.WriteLine("----- Order 2 Details -----");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\n" + order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Order Cost: ${order2.CalculateTotalCost():0.00}");
        Console.WriteLine("---------------------------\n");
    }
}
