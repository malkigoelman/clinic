using Mirpaha.Entities;

namespace Mirpaha.Clinic.Core.Services
{
    public interface IDoctorService
    {
        List<Doctor> GetDoctors();
        Doctor GetDoctor(int id);
        List<Specialization> GetSpecializations(int doctorId);
        void AddDoctor(Doctor doctor);
        void RemoveDoctor(int doctorId);
        void UpdateDoctor(int doctorId,Doctor doctor);
    }
}
