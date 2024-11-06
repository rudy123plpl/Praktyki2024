namespace ITshop.Models
{
    public class OrderItemViewModel
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Price per unit
    }
}