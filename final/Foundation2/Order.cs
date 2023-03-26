public class Order
{
    // ATTRIBUTES //
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    // METHODS //
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double OrderCost()
    {
        double total = 0;
        int shippingCost = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice();
        }

        if (_customer.UsaShipping() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        double grandTotal = total + shippingCost;
        return grandTotal;
    }

    public void PackingLabel()
    {
        Console.WriteLine("Products:");
        Console.WriteLine("");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product name: {product.GetName()}");
            Console.WriteLine($"Product ID: {product.GetId()}");
            Console.WriteLine("");
        }   

    }

    public string ShippingLabel()
    {
        Console.WriteLine("Shipping Info:");
        Console.WriteLine("");
        
        Console.WriteLine($"Customer Name: {_customer.GetName()}");
        Console.WriteLine($"Shipping Address: {_customer.GetAddress()}");

        return $"Customer Name: {_customer.GetName()}. Shipping Address: {_customer.GetAddress()}";

    }

    // CONSTRUCTORS //
    public Order(Customer customer)
    {
        _customer = customer;
    }
}