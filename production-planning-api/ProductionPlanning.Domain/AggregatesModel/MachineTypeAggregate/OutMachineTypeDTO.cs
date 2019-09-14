using System.Collections.Generic;
using ProductionPlanning.Domain.AggregatesModel.OperationAggregate;

namespace ProductionPlanning.Domain.AggregatesModel.MachineTypeAggregate
{
    public class OutMachineTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<OutOperationDTO> Operations { get; set; }
    }
}