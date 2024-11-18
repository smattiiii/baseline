using Microsoft.EntityFrameworkCore.Migrations;

namespace OS_GJ_Tutoring.Models
{
    public class SessionsDB
    {
        public int Id { get; set; }
        public string? TutorName { get; set; }
        public string? TutorSubject { get; set; }
        public DateTime Time { get; set; }
    }
}
