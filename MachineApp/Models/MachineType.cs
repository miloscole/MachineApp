namespace MachineApp.Models
{
    public class MachineType
    {
        public int Id { get; set; }
        public required string TypeName { get; set; }
        public string? Description { get; set; }
    }
}
