using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITshop.Models
{
    public class Device
    {
        public Device()
        {
            DeviceAssignments = new List<DeviceAssignment>();
        }
        [Key]
        public int DeviceId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Id { get; set; }
        public string? Model { get; set; }
        public decimal Price { get; set; }
        public int Stock {  get; set; }
        public int CategoryId { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public string ImageUrl { get; set; } = "https://via.placeholder.com/150";

        [ValidateNever]
        public Category? Category { get; set; }
        [ValidateNever]
        public ICollection<OrderItem>? OrderItems { get; set; }
        [ValidateNever]
        public ICollection<DeviceAssignment>? DeviceAssignments { get; set; }
    }
}