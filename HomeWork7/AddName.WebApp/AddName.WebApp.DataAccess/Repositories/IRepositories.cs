using System.Collections.Generic;

namespace AddName.WebApp.DataAccess.Repositories
{
    public interface IRepositories<T>
    {
        T GetById(int id);
        List<T> GetAll();
        int Insert(T entity);
        void Update(T entity);
        void DeleteById(int id);
    }
}
