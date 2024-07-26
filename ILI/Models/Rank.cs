using System.ComponentModel.DataAnnotations.Schema;

namespace ILI.Models
{
    internal class Rank
    {
        public Guid RankId { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string RankName { get; set; }
    }
}
