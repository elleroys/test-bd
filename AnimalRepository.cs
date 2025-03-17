namespace Animalpedia
{
    public class AnimalRepository : GenericRepository<Animal>
    {
        public IEnumerable<Animal> FilterByType(string type)
        {
            return GetAll().Where(a => a.Type.Equals(type, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Animal> FilterByFamily(string family)
        {
            return GetAll().Where(a => a.Family.Equals(family, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Animal> SortByName()
        {
            return GetAll().OrderBy(a => a.Name);
        }

        public IEnumerable<Animal> SortById()
        {
            return GetAll().OrderBy(a => a.Id);
        }
    }
}
