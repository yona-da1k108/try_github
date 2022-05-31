#nullable disable
using System.ComponentModel.DataAnnotations;
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Tables
{
    public class Reply
    {
        [Key]
        public long Reply_Id { get; set; }

        public string Reply_Content { get; set; }
        public long Replysonzai_Id { get; set; }
        public long ThanksCardId { get; set; }
        public virtual ThanksCard ThanksCard { get; set; }
        public virtual Employee Employee_Id  { get; set; }


    }
}
