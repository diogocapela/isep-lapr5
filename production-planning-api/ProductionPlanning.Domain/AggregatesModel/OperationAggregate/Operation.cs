using System.Collections.Generic;
using ProductionPlanning.Domain.AggregatesModel.MachineTypeOperationAggregate;
using ProductionPlanning.Domain.AggregatesModel.ToolAggregate;

namespace ProductionPlanning.Domain.AggregatesModel.OperationAggregate
{
    public class Operation 
    {
        public int Id { get; set; }
        public string OperationName { get; set; }
        public string Description { get; set; }
        public int TimeTakes { get; set; }
        public Tool Tool { get; set; }
        public int StartupTime { get; set; }
        public virtual ICollection<MachineTypeOperation> MachineTypeOperations { get; set; }
    }
}