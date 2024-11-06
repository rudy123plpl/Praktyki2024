using ITshop.Models;

namespace ITshop.Models
{
    public class OrderViewModel
    {
        public decimal TotalAmount { get; set; }
        public List<OrderItemViewModel> OrderItems { get; set; }

        public IEnumerable<Device> Devices { get; set; }
    }
}