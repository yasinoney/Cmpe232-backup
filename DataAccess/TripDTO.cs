using System;

namespace DataAccess
{
    public class TripDTO
    {
        public int TripID { get; set; }
        public int RouteID { get; set; }
        public int BusID { get; set; } // Hangi otobüs gidecek?
        public decimal BaseFare { get; set; } = 250; // Başlangıç fiyatı
        public DateTime? ScheduledDeparture { get; set; } = DateTime.Now;
        public DateTime? ScheduledArrival { get; set; } = DateTime.Now.AddHours(4);
    }
}