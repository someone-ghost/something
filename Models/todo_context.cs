using Microsoft.EntityFrameworkCore;
namespace Student_Task_Management.Models
{
    public class todo_context : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }
        
        public DbSet<Project> Projects  { get; set; }
        public DbSet<Team_Member> Team_Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=FS-COMLAB3TUTOR;Database=Student_Task_Management;Trust Server Certificate=True; User ID=sa;Password=FIATS@2024");
        }
    }
}
