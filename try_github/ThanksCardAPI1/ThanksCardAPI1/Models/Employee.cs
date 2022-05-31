#nullable disable
namespace ThanksCardAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int cd { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public int sonzai_id { get; set; }
        public long Send_Number { get; set; }
        public long Receive_Number { get; set; }
    }
}