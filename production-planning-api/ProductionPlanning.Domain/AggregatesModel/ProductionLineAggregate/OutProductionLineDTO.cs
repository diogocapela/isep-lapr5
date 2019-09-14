using System.Collections.Generic;

namespace ProductionPlanning.Domain.AggregatesModel.ProductionLineAggregate
{
    public class OutProductionLineDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> Machines { get; set; }
    }
}