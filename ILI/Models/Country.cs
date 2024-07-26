using System.ComponentModel.DataAnnotations.Schema;

namespace ILI.Models
{
    internal class Country
    {
        public Guid CountryId { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string CountryName { get; set; }
    }
}
