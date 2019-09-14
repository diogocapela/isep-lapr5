using System.Collections.Generic;
using ProductionPlanning.Domain.AggregatesModel.MachineAggregate;

namespace ProductionPlanning.Domain.AggregatesModel.ProductionLineAggregate
{
    public class ProductionLine 

    {
        public int Id { get; set; }
        public string ProductionName { get; set; }
        public string Description { get; set; }
        public virtual List<Machine> Machines { get; set; }
    }
}