using Microsoft.AspNetCore.Mvc;
using Mirpaha.Entities;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mirpaha.Controllers
{
    [Route("clinic/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        public static List<Appointment> appointments = new List<Appointment>();
        // GET: api/<AppointmentController>
        [HttpGet]
        public List<Appointment> Get()
        {
            return appointments;
        }

        // GET api/<AppointmentController>/5
        [HttpGet("clients/{clientId}")]
        public List<Appointment>  GetByClient(int clientId)
        {
            List<Appointment> p= appointments.FindAll(x => x.ClientId == clientId);
            if (p.Count() == 0)
                //throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
                throw new Exception("404");
            return p;
        }
        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public Appointment Get(int id)
        {
            Appointment p= appointments.Find(x => x.Id == id);
            if (p == null)
                //throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
                throw new Exception("404");
            return p;
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public void Post([Microsoft.AspNetCore.Mvc.FromBody] Appointment appointment)
        {
            appointments.Add(appointment);
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Appointment appointment)
        {
            Appointment appointment1 = appointments.Find(c => c.Id == id);
            if(appointment1==null)
                //throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
                throw new Exception("404");
            appointments.Remove(appointment1);
            appointments.Add(appointment);
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Appointment appointment1 = appointments.Find(c => c.Id == id);
            if(appointment1==null)
                //throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
                throw new Exception("404");
            appointments.Remove(appointment1);
        }
    }
}
