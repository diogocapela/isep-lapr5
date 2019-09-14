namespace ProductionPlanning.Domain.AggregatesModel.OperationAggregate
{
    public class InOperationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TimeTakes { get; set; }
        public int StartupTime { get; set; }
        public string Tool { set; get; }
    }
}
