#nullable disable
using System.ComponentModel.DataAnnotations;

namespace ThanksCardServer2.Models
{
    public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }

        public int Cd { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Sonzai_id { get; set; }
        public long Send_Number { get; set; }
        public long Receive_Number { get; set; }
        public long BelongsId { get; set; }
        public virtual Belongs Belongs { get; set; }

    }
}
