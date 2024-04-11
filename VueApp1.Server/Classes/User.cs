using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;

namespace VueApp1.Server.Classes
{
    [Table("User")]
    public class User
    {
        
        [Key]
        public int user_id { get; set; }
        public string fullname { get; set; }
        public int phone_number { get; set; }
        public string email { get; set; }
        public int status_id { get; set; }
        public string cabinet { get; set; }
        public string job_title { get; set; }
        public string supervisor { get; set;}
        public int organization_id { get; set; }
    }
}
