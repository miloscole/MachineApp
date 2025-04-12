namespace MachineApp.Models
{
    public class MachineLog
    {
        public int Id { get; set; }
        public int MachineId { get; set; }
        public DateTime? StartProductionDate { get; set; }
        public DateTime? EndProductionDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
