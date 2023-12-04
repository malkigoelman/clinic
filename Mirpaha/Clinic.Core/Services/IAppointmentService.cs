using Mirpaha.Entities;

namespace Mirpaha.Clinic.Core.Services
{
    public interface IAppointmentService
    {
        List<Appointment> GetAppointments();
        Appointment GetAppointment(int id);
        List<Appointment> GetAppointmentsByClientId(int clientId);
        void AddAppointment(Appointment appointment);
        void RemoveAppointment(int id);
        void UpdateAppointment(int id, Appointment appointment);


    }
}
