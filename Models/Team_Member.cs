using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Task_Management.Models
{
    public class Team_Member
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int team_member_id { get; set; }
       
        
        [Required, MaxLength(100)]
        public string name { get; set; }
        
        
        [Required, MaxLength(100)]
        public string email { get; set; }
       
        
        [Required, MaxLength(50)]
        public string role { get; set; }

        public List<Tasks> Task { get; set; }


        //        o Id(Primary Key)
        //o Name(string, max length 100)
        //o Email(string, max length 100, unique)
        //o Role(string, max length 50)

    }
}
