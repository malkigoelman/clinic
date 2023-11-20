using Microsoft.AspNetCore.Mvc;
using Mirpaha.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mirpaha.Controllers
{
    [Route("clinic/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        public static List<Client> Clients = new List<Client>();
        // GET: api/<ClientController>
        [HttpGet]
        public List<Client> Get()
        {
            return Clients;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            Client c = Clients.Find(c => c.Id == id);
            if(c==null)
                //throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
                throw new Exception("404");
            return c;
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([Microsoft.AspNetCore.Mvc.FromBody] Client client)
        {
            Clients.Add(client);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client client)
        {
            Client client1 = Clients.Find(c => c.Id == id);
            if (client1 == null)
                //throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
                throw new Exception("404");
            Clients.Remove(client1);
            Clients.Add(client);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Client client1 = Clients.Find(c => c.Id == id);
            if (client1 == null)
                //throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
                throw new Exception("404");
            Clients.Remove(client1);
        }
    }
}
