using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GenericDal<T> : IGenericDal<T> where T : class
    {
        private List<T> _items;
        public GenericDal(List<T> items)
        {
            _items = items;
        }
        public async Task AddAsync(T entity)
        {
            _items.Add(entity);
            await Task.CompletedTask;
        }

        public IQueryable<T> GetAll()
        {
            return _items.AsQueryable();
        }

        public void Remove(T entity)
        {
            _items.Remove(entity);

            //Silme başarısız olursa bunu dene
            /* T entityToRemove = _items.FirstOrDefault(item => GetId(item) == id);
            if (entityToRemove != null)
            {
                _items.Remove(entityToRemove);
            }*/
        }

        public void Update(T entity)
        {   
            int index = _items.FindIndex(item => GetId(item) == GetId(entity));
            if (index != -1)
            {
                _items[index] = entity;
            }
        }
        private int GetId(T entity)
        {
            // T'nin Id özelliğinin ismi ve tipi belirli değilse burada uygun şekilde özelliğe erişmeliyiz.
            // Örneğin: entity.Id, entity.ID gibi
            // Bu örnekte varsayılan olarak bir Id özelliği olduğunu varsayıyoruz.
            return (int)entity.GetType().GetProperty("Id").GetValue(entity);
        }
    }
}
