namespace BebeEmFoco.Application.DTOs.Vaccines
{
    public class VaccineResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RecommendedWeek { get; set; }
        public bool Taken { get; set; }
    }
}
