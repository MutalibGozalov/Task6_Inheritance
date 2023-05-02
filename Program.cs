using System.Reflection;
using TaskInheritance.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        CustomerAdress adress = new CustomerAdress(1, "Main adress", "USA", "LA", "Beacon Hills", "221 Baker Street", 16);
        CustomerMail mail = new CustomerMail(1, "My mail", "bruce.wayne@gotham.cdc");
        CustomerPhone phone = new CustomerPhone(1, "My cell", 370, "987 77 7");

        Customer customer = new(1, "Bruce", "Waynr", adress, mail, phone);
        string ShipStatus(Order order){
            return order.Status;
        }

        Order order = new(1, customer, 550.99, 25, DateTime.Now, new DateTime(2023, 05, 01), 1, 1, ShippingStatus.Delivered);

        string status = ShipStatus(order);
        Console.WriteLine("Shipping status: {0}", status);
    }
}