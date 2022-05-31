#nullable disable
using System.ComponentModel.DataAnnotations;

namespace ThanksCardServer2.Models
{
    public class ThanksCard
    {
        [Key]
      public long ThanksCard_Id { get; set; }
      
      public DateTime ThanksCard_Date { get; set; }
      public long SenderId { get; set; }
        public string SenderName { get; set; }
      public virtual Employee Sender { get; set; }
      public long DestinationId { get; set; }
        public virtual Employee Destination { get; set; }
      public long Title_Id { get; set; }
      public string ThanksCard_Content { get; set; }
      public long Template_Id { get; set; }
      public long Good_Number { get; set; }
      public string Alreadtread { get; set; }
      public long Thankscardsonzai_Id { get; set; }
    }
}