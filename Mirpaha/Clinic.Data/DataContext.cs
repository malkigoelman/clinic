using Mirpaha.Entities;
//using (var reader = new StreamReader("data.csv"))
//using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
namespace Mirpaha
{
    public class DataContext
    {
        public List<Appointment> Appointments { get; set; }
        public List<Client> Clients { get; set; }
        public List<Doctor> Doctors { get; set; }

        public DataContext()
        {
            Appointments = new List<Appointment>()
            {
                new Appointment(123,34),
                new Appointment(423,394),
                new Appointment(163,84)
            };
            Clients = new List<Client>()
            {
                new Client(6,"moshe"),
                new Client(7,"bracha"),
                new Client(4,"mustafa"),
                new Client(34,"malki")
            };
            Doctors = new List<Doctor>()
            {
                new Doctor(87,"raini"),
                new Doctor(43,"odeli"),
                new Doctor(75,"chasan suliman")
            };
        }
    }
}
