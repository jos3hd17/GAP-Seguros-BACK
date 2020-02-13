using System;
using System.Collections.Generic;
namespace policy_back.Data
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        int Count(int id);
        T GetById(int id);
        T[] GetAll();
        IEnumerable<T> FindBy(QueryParams<T> queryParams);
    }   
}
