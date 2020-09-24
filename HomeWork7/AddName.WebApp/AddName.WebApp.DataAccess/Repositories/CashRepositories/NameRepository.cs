using AddName.WebApp.DomainModels.Models;
using System.Collections.Generic;
using System.Linq;

namespace AddName.WebApp.DataAccess.Repositories.CashRepositories
{
    public class NameRepository : IRepositories<Name>
    {

        public List<Name> GetAll()
        {
            return StaticDB.Names;
        }

        public Name GetById(int id)
        {
            return StaticDB.Names.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Name entity)
        {
            StaticDB.Names.Add(entity);
            return entity.Id;
        }

        public void Update(Name entity)
        {
            var name = StaticDB.Names.FirstOrDefault(x=>x.Id == entity.Id);
            if (name!=null)
            {
                var indexPosition = StaticDB.Names.IndexOf(name);
                StaticDB.Names[indexPosition] = entity;
            }
          
        }

        public void DeleteById(int id)
        {
            var name = StaticDB.Names.FirstOrDefault(x=>x.Id==id);
            StaticDB.Names.Remove(name);
        }


    }
}
