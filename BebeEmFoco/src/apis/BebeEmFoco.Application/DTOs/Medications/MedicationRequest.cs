namespace BebeEmFoco.Application.DTOs.Medications
{
    public class MedicationRequest
    {
        public string Name { get; set; }
        public string Dose { get; set; }
        public TimeSpan Time { get; set; }
        public bool Active { get; set; } = true;
    }
}
