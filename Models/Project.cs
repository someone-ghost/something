using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Task_Management.Models
{
    public class Project
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int project_id { get; set; }
       
        
        
        [Required, MaxLength(100)]
        public string name { get; set; }
       
        
        
        [Required, MaxLength(500)]
        public string description { get; set; }
      
        
        
        [Required]
        public DateTime start_date { get; set; }
       
        
        
        [Required]
        public DateTime end_date { get; set; }
        public List<Tasks> Task { get; set; }



        //        o Id(Primary Key)
        //o Name(string, max length 100)
        //o Description(string, max length 500)
        //o StartDate(DateTime)
        //o EndDate(DateTime)

    }
}
