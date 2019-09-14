using System.Collections.Generic;
using ProductionPlanning.Domain.AggregatesModel.MachineTypeOperationAggregate;

namespace ProductionPlanning.Domain.AggregatesModel.MachineTypeAggregate
{
    public class MachineType
    {
        public int Id { get; set; }
        public string NameMachineType { get; set; }
        public string Description { get; set; }
        public virtual ICollection<MachineTypeOperation> MachineTypeOperations { get; set; }
    }
}