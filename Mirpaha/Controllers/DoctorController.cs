using Microsoft.AspNetCore.Mvc;
using Mirpaha.Entities;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mirpaha.Controllers
{
    [Route("clinic/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        public static List<Doctor> Doctors = new List<Doctor>();
        // GET: api/<DoctorController>
        [HttpGet]
        public List<Doctor> Get()
        {
            return Doctors;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{code}")]
        public Doctor Get(int code)
        {
            Doctor d = Doctors.Find(d => d.DoctorId == code);
            if (d == null)
                //throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
                throw new Exception("404"); return d;
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Doctor doctor)
        {
            Doctors.Add(doctor);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{code}")]
        public void Put(int code, [Microsoft.AspNetCore.Mvc.FromBody] Doctor doctor)
        {
            Doctor doctor1 = Doctors.Find(d => d.DoctorId == code);
            //כאן צריך לזרוק שגיאה
            if (doctor1 == null)
                //throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
                throw new Exception("404");
            Doctors.Remove(doctor1);
            Doctors.Add(doctor);
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{code}")]
        public void Delete(int code)
        {
            Doctor doctor1 = Doctors.Find(d => d.DoctorId == code);
            //כאן צריך לזרוק שגיאה
            if (doctor1 == null)
                //throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
                throw new Exception("404");
            Doctors.Remove(doctor1);
        }
    }
}
