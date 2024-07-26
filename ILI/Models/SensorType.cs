using System.ComponentModel.DataAnnotations.Schema;

namespace ILI.Models
{
    internal class SensorType
    {
        public Guid SensorTypeId { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string SensorTypeName { get; set; }
    }
}
