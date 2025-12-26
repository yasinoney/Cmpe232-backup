namespace DataAccess
{
    public class BusDTO
    {
        public int BusID { get; set; }
        public string Plate { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int? Capacity { get; set; }
        public string Status { get; set; } = "Active"; // Varsayılan olarak Aktif
        public int? Year { get; set; }
    }
}