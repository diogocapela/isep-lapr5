using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProductionPlanning.Domain.AggregatesModel.MachineTypeAggregate;

namespace ProductionPlanning.Domain.AggregatesModel.MachineAggregate
{
    public class Machine
    {
        public int Id { get; set; }
        public string MachineName { get; set; }
        public string Description { get; set; }
        public virtual MachineType MachineType { get; set; }
        public bool Active { get; set; }
    }
}