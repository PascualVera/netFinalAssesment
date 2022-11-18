namespace finalAssesmentLaBestia.Models
{
    public class Claim
    {

        public int id { get; set; }
        public string Description { get; set; } = String.Empty; 

        public string Status { get; set; } = String.Empty;

        public DateTime Date { get; set; }
        public int Vehicle_id { get; set; }
       
    }
}
