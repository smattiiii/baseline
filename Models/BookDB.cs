namespace OS_GJ_Tutoring.Models
{
    public class BookDB
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SurName { get; set; }
        public DateTime? Time { get; set; } = DateTime.Now;
        public int? TicketoneQty { get; set; }
        public int? TickettwoQty { get; set; }
        public int? TicketthreeQty { get; set; }
        public int? TicketfourQty { get; set; }
        public int? TicketfiveQty { get; set; }
        public int? TicketsixQty { get; set; }
        public int? TicketsevenQty { get; set; }
        public int? TicketeightQty { get; set; }
        public string? YearPass { get; set; }
    }
}
