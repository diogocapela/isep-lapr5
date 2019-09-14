using ProductionPlanning.Domain.AggregatesModel.MachineTypeAggregate;
using ProductionPlanning.Domain.AggregatesModel.OperationAggregate;

namespace ProductionPlanning.Domain.AggregatesModel.MachineTypeOperationAggregate
{
    public class MachineTypeOperation
    {
        public int MachineTypeId { get; set; }
        public MachineType Machinetype { get; set; }
        public int OperationId { get; set; }
        public Operation Operation { get; set; }
    }
}