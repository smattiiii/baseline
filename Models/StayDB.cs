namespace OS_GJ_Tutoring.Models
{
    //Dataset for Lodge Stay Bookings
    public class StayDB
    {
        //Data Types
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Date { get; set; }
        public int? NumNight { get; set; }
        public int? NumVisitors { get; set; }
        public string? RoomName { get; set; }
    }
}
