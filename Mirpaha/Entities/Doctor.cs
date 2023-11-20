namespace Mirpaha.Entities
{
    public enum Specialization { General, Dentist, Ophthalmologist }
    public enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
    public class Doctor
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public DateOnly Birthday { get; set; }
        public string Address { get; set; }
        public Specialization specialization { get; set; }
        public string Phone { get; set; }
        public List<Shift> Shifts { get; set; }
    }
    public class Shift
    {
        public Days Day { get; set; }
        public TimeOnly Start { get; set; }
        public TimeOnly End { get; set; }
    }
}
