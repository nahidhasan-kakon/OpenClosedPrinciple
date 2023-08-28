
class Program
{
    static void Main(string[] args)
    {
        List<OrderItem> orderItems = new List<OrderItem>
        {
            new Product { Price = 10, Quantity = 2 },
            new Discount { Amount = 5 },
            new ShippingFee { Fee = 3 }
        };

        double totalCost = orderItems.Sum(item => item.CalculateCost());
        Console.WriteLine($"Total Cost: {totalCost}");
    }
}
public interface OrderItem
{
    public  double CalculateCost();
}

public class Product : OrderItem
{
    public double Price { get; set; }
    public int Quantity { get; set; }

    public  double CalculateCost()
    {
        return Price * Quantity;
    }
}

public class Discount : OrderItem
{
    public double Amount { get; set; }

    public double CalculateCost()
    {
        return -Amount; // Negative value represents a discount
    }
}

public class ShippingFee : OrderItem
{
    public double Fee { get; set; }

    public double CalculateCost()
    {
        return Fee;
    }
}

