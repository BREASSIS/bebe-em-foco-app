namespace BebeEmFoco.Application.DTOs.Medications
{
    public class MedicationResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dose { get; set; }
        public TimeSpan Time { get; set; }
        public bool Active { get; set; }
    }
}
