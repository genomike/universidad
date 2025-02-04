namespace Universidad.GestionVentas.Domain.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public decimal Amount { get; set; }
    }
}
