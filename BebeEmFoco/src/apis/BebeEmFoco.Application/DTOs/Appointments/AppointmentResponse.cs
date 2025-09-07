namespace BebeEmFoco.Application.DTOs.Appointments
{
    public class AppointmentResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Notes { get; set; }
    }
}
