using System.ComponentModel.DataAnnotations.Schema;

namespace DotaApp.Models
{
    [Table("group_item")]
    public class GroupItem
    {
        public int id { get; set; }
        public required string name { get; set; }
    }
}
