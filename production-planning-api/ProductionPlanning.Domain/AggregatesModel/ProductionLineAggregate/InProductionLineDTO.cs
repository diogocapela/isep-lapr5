using System.Collections.Generic;

namespace ProductionPlanning.Domain.AggregatesModel.ProductionLineAggregate
{
    public class InProductionLineDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> Machines { get; set; }
    }
}