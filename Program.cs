using System.Reflection;
using TaskInheritance.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        ShippingStatus ShipStatus(Order order){
            return order.Status;
        }

        Order order = new();
        order.Status = ShippingStatus.Ready;

        ShippingStatus status = ShipStatus(order);
        string statusString = Enum.GetName(typeof(ShippingStatus), status);
        Console.WriteLine("Shipping status: {0}", statusString);
    }
}