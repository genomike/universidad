namespace Universidad.GestionHorarios.Domain.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public string TimeSlot { get; set; }
    }
}
