namespace ITshop.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public int DeviceId { get; set; }
        public Device? Device { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
     }
}