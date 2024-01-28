using System.ComponentModel.DataAnnotations.Schema;

namespace DotaApp.Models
{
    [Table("hero_item")]
    public class HeroItem
    {
        public int id { get; set; }

        public int hero_id { get; set; }
        [ForeignKey("hero_id")]
        public virtual Hero Hero { get; set; }

        public int item_id { get; set; }
        [ForeignKey("item_id")]
        public virtual Item Item { get; set; }

        public int group_item_id { get; set; }
        [ForeignKey("group_item_id")]
        public virtual GroupItem GroupItem { get; set; }
    }
}
