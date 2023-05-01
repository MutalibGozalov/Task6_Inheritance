namespace TaskInheritance.Models
{
    public enum ShippingStatus
    {
        OrderReceived, // Sipariş Alındı
        Ready,         // Siparişiniz Hazırlandı
        PickedUp,      // Siparişiniz Kargoye Verildi
        InTransit,     // Siparişiniz Teslimat İçin Yolda
        AtDestination, // Siparişin Teslimat Noktasında
        Delivered,     // Siparişiniz Teslim Edildi
        Failed      
    }
}