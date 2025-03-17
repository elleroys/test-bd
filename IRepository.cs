using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

// Інтерфейс IRepository<T> з методами Create, Read, Update, Delete.
// Загальний клас Repository<T>, який імплементує IRepository<T>, з підтримкою сортування за ID.

namespace Animalpedia
{
    public class BaseEntity
    {
        public int Id { get; }
        protected BaseEntity(int id)
        {
            Id = id;
        }
    }
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        void Create(T entity); // C
        T GetById(int id); // R
        void Update(T entity); // U
        void Delete(T entity); // D

    }

    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private List<T> entities = new List<T>();

        public T GetById(int id)
        {
            return entities.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.OrderBy(e => e.Id);
        }

        public void Create(T entity)
        {
            entities.Add(entity);
        }

        public void Update(T entity)
        {
            var index = entities.FindIndex(a => a.Id == entity.Id);
            if (index >= 0)
            {
                entities[index] = entity;
            }
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
        }
    }
}
