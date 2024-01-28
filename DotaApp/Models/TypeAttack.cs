using System.ComponentModel.DataAnnotations.Schema;

namespace DotaApp.Models
{
    [Table("type_attack")]
    public class TypeAttack
    {
        public int Id { get; set; }
        public required string name { get; set; }
    }
}