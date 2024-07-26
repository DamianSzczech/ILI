using System.ComponentModel.DataAnnotations.Schema;

namespace ILI.Models
{
    internal class Soldier
    {
        public Guid SoldierId { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string Name { get; set; }

        public Guid RankId { get; set; }

        public Rank Rank { get; set; }

        public Guid CountryId { get; set; }

        public Country Country { get; set; }

        public string TrainingInfo { get; set; }

        [Column(TypeName = "decimal(9,6)")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "decimal(9,6)")]
        public decimal Longitude { get; set; }

        public Guid SensorId { get; set; }

        public Sensor Sensor { get; set; }
    }
}
