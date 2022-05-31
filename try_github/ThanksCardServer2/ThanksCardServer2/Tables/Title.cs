#nullable disable
using System.ComponentModel.DataAnnotations;

namespace ThanksCardServer2.Models
{
    public class Title
    {
        [Key]
        public long Title_Id { get; set; }

        public string Title_Name { get; set; }
    }
}