using Mirpaha.Clinic.Core.Repositories;
using Mirpaha.Entities;

namespace Mirpaha.Clinic.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _dataContext;
        public ClientRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddClient(Client client)
        {
            _dataContext.Clients.Add(client);
        }

        public void DeleteClient(int id)
        {
            _dataContext.Clients.Remove(GetClientById(id));
        }

        public Client GetClientById(int id)
        {
            return _dataContext.Clients.Find(p => p.Id == id);
        }

        public List<Client> GetClients()
        {
            return _dataContext.Clients;
        }

        public void UpdateClient(int id, Client client)
        {
            DeleteClient(id);
            AddClient(client);
        }
    }
}
