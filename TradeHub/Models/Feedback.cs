using System.ComponentModel.DataAnnotations;

namespace TradeHub.Models
{
    public class Feedback
    {
        [Key]
        public int feedback_id { get; set; }
        public int user_name { get; set; }
        public string user_message { get; set; }
    }
}
