namespace MachineApp.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string SerialNumber { get; set; }
        public string? Specifications { get; set; }
        public int? MachineTypeId { get; set; }
        public string? MachineType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
