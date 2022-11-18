namespace finalAssesmentLaBestia.Models
{
    public class Vehicle
    {
       public int id { get; set; }

       public string Brand { get; set; } = String.Empty;
        
        public string Vin { get; set; } = String.Empty;

        public string Color { get; set; } = String.Empty;

        public int Year { get; set; } 

        public int Owner_id { get; set; }
    }
}
