using System.ComponentModel.DataAnnotations.Schema;

namespace DotaApp.Models
{
    [Table("update")]
    public class Update
    {
        public int id { get; set; }
        public required string title { get; set; }
        public required string description { get; set; }
        public string smallDescription
        {
            get {
                    return description.Substring(0, 200);
            }
        }
    }
}
