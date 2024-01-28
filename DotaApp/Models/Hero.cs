using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotaApp.Models
{
    public class Hero
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string diff { get; set; }
        public required string image { get; set; }
        public string? description { get; set; }

        public int attribute_id { get; set; }
        [ForeignKey("attribute_id")]
        public required virtual Attribute Attribute { get; set; }

        public int type_attack_id { get; set; }
        [ForeignKey("type_attack_id")]
        public required virtual TypeAttack TypeAttack { get; set; }

        public List<Skill>? Skills { get; set; }
        [NotMapped]
        public List<GroupItemViewModel>? GroupItemsWithItems { get; set; }
    }
}
