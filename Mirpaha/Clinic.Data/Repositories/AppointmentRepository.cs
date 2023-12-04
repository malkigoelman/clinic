using Mirpaha.Clinic.Core.Repositories;
using Mirpaha.Entities;

namespace Mirpaha.Clinic.Data.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DataContext _dataContext;
        public AppointmentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddAppointment(Appointment appointment)
        {
            _dataContext.Appointments.Add(appointment);
        }

        public void DeleteAppointment(int id)
        {
            _dataContext.Appointments.Remove(GetAppointmentById(id));
        }

        public Appointment GetAppointmentById(int id)
        {
            return _dataContext.Appointments.Find(a => a.Id == id);
        }

        public List<Appointment> GetAppointments()
        {
            return _dataContext.Appointments;
        }

        public void UpdateAppointment(int id, Appointment appointment)
        {
            DeleteAppointment(id);
            AddAppointment(appointment);
        }
    }
}
