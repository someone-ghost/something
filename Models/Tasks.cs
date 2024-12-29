using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Task_Management.Models
{
    public class Tasks
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]        
        public int id { get; set; }


        [Required, MaxLength(100)]
        public string title { get; set; }


        [Required, MaxLength(500)]
        public string description { get; set; }


        [Required]
        public string status { get; set; }


        [Required]
        public string priority { get; set; }


        [Required]
        DateTime deadline { get; set; }


        [ForeignKey("Project.cs")]
        public int project_id { get; set; }        
        
        
        [ForeignKey("Team_Member.cs")]
        public int team_member_id { get; set; }



        // Title(string, max length 100)
        // Description(string, max length 500)
        // Status(Pending, In Progress, Completed)
        // Priority(Low, Medium, High)
        // Deadline(DateTime)
        // ProjectId(Foreign Key to Project)
        // TeamMemberId(Foreign Key to TeamMember)

    }
}
