using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ST10357451_CLDV6211_POE_Part1.Models
{
    public class WorkPage
    {
        public int CraftID { get; set; }
        public String? Name { get; set; }
        public string? Category { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public double Price { get; set; }
        public String ImageURL { get; set; }
    }
}
