using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ITshop.Models
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Name { get; set; }

        [ValidateNever]
        public ICollection<DeviceAssignment> DeviceAssignments { get; set; }
    }
}