#nullable disable
using System.ComponentModel.DataAnnotations;

namespace ThanksCardServer2.Models
{
    public class Template
    {
        [Key]
        public long Template_Id { get; set; }

        public string Template_Name { get; set; }
        public string Template_Content { get; set; }
    }
}