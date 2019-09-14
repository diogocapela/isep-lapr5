using System.Collections.Generic;

namespace ProductionPlanning.Domain.AggregatesModel.MachineTypeAggregate
{
    public class InMachineTypeDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> Operations { get; set; }
    }
}
