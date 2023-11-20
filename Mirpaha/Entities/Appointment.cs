namespace Mirpaha.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int ClientId { get; set; }
       // public TimeOnly Time { get; set; }
        //public DateOnly Date { get; set; }
        public DateTime Date_Time { get; set; }
        public int Room { get; set; }
        public Specialization Treatment { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }
    }
}
