using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Online Ordering program!");

        Address address1 = new Address("6116 Sandstone Mesa Dr", "Las Vegas", "NV", "USA");
        Customer customer1 = new Customer("Trent Nelson", address1);
        Order order1 = new Order(customer1);

        Product skateboard = new Product("Skateboard", "45669", 52.00, 1);
        order1.AddProduct(skateboard);

        Product bearings = new Product("Bones Red Bearings", "35565", 19.99, 2);
        order1.AddProduct(bearings);

        Product trucks = new Product("Thunder trucks 148", "122148", 27.50, 2);
        order1.AddProduct(trucks);

        double order1Cost = order1.OrderCost();
        Console.WriteLine($"Total cost for order: ${order1Cost}");

        order1.PackingLabel();
        order1.ShippingLabel();

        Address address2 = new Address("194 W 450 N", "American Fork", "UT", "Africa");
        Customer customer2 = new Customer("Taylor Nelson", address2);
        Order order2 = new Order(customer2);

        Product banana = new Product("Banana", "13456", 2, 4);
        order2.AddProduct(banana);

        Product apple = new Product("Apple", "12345", 1, 5);
        order2.AddProduct(apple);

        Product orange = new Product("Orange", "45678", 3.50, 2);
        order2.AddProduct(orange);

        double order2Cost = order2.OrderCost();
        Console.WriteLine($"Total cost for order: ${order2Cost}");

        order2.PackingLabel();
        order2.ShippingLabel();
    
    }
}