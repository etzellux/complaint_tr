using System.ComponentModel.DataAnnotations;
using complaint_tr.Areas.Identity.Data;

namespace complaint_tr.Models
{
    public class Complaint
    {
        public int Id { get; set; }
        public string ? province { get; set; }
        public string ? district { get; set; }
        public string ? neighbourhood { get; set; } 
        public string ? second_line { get; set; }
        public float ? longitude { get; set; }
        public float ? latitude { get; set; }
        public bool is_approved {get; set; }
        public int type { get; set; }
        public DateTime posting_date { get; set; }
        public User ? posted_by { get; set; } = null!;
    }
}