using System;
using System.Collections.Generic;
using policy_back.Models;

namespace policy_back.Data
{
    public class Repository<T> : IRepository<T> where T: Entity, new()
    {
        public Repository()
        {
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public int Count(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindBy(QueryParams<T> queryParams)
        {
            throw new NotImplementedException();
        }

        public T[] GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
