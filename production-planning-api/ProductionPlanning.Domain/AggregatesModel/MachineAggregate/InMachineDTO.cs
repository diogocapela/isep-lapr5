namespace ProductionPlanning.Domain.AggregatesModel.MachineAggregate
{
    public class InMachineDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MachineType { get; set; }
        
        public bool Active { get; set; }
    }
}
