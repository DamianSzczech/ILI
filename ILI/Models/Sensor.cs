using System.ComponentModel.DataAnnotations.Schema;

namespace ILI.Models
{
    internal class Sensor
    {
        public Guid SensorId { get; set; }

        public Guid SensorTypeId { get; set; }

        public SensorType SensorType { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string SensorName { get; set; }
    }
}
