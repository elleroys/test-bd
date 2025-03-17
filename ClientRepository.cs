namespace Animalpedia
{
    public class ClientRepository : GenericRepository<Client>
    {

        public IEnumerable<Client> FilterByAccess(string access)
        {
            return GetAll().Where(c => c.Access.Equals(access, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Client> SortByLogin()
        {
            return GetAll().OrderBy(c => c.Login);
        }
    }
}
