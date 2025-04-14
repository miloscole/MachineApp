namespace MachineApp.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Specifications { get; set; } = string.Empty;
        public int MachineTypeId { get; set; }
        public string MachineType { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
