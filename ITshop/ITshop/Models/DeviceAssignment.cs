namespace ITshop.Models
{
    public class DeviceAssignment
    {
        public int DeviceId { get; set; }
        public Device Device { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
    }
}