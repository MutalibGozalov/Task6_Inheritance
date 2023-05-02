namespace TaskInheritance.Models
{
    public static class ShippingStatus
    {
        public const string OrderReceived = "OrderReceived"; // Sipariş Alındı
        public const string Ready = "Ready";                 // Siparişiniz Hazırlandı
        public const string PickedUp = "PickedUp";           // Siparişiniz Kargoye Verildi
        public const string InTransit = "InTransit";         // Siparişiniz Teslimat İçin Yolda
        public const string AtDestination = "AtDestination"; // Siparişin Teslimat Noktasında
        public const string Delivered= "Delivered";          // Siparişiniz Teslim Edildi
        public const string Failed = "Failed";  
    }
}