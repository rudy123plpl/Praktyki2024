namespace ITshop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Device> Devices { get; set; }
    }
}