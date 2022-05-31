#nullable disable
using System.ComponentModel.DataAnnotations;

namespace ThanksCardServer2.Models
{
    public class Belongs
    {
        [Key]
        public long Belongs_Id { get; set; }

        public string Belongs_Name { get; set; }
        public long Belongssonzai_id { get; set; }
        public long Parent_Id { get; set; }
    }
}