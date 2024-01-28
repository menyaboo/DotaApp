using System.ComponentModel.DataAnnotations.Schema;

namespace DotaApp.Models
{
    public class Skill
    {
        public int id { get; set; }
        public required string image { get; set; }
        public required string name { get; set; }
        public required string description { get; set; }
        public required string spells { get; set; }
        public string? cooldown { get; set; }
        public string? mana { get; set; }

        public required int hero_id { get; set; }
        [ForeignKey("hero_id")]
        public required virtual Hero Hero { get; set; }
    }
}
