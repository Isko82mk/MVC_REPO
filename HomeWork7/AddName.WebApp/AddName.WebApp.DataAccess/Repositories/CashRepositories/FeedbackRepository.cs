using AddName.WebApp.DomainModels.Models;
using System.Collections.Generic;
using System.Linq;

namespace AddName.WebApp.DataAccess.Repositories.CashRepositories
{
    public class FeedbackRepository : IRepositories<Feedback>
    {


        public List<Feedback> GetAll()
        {
            return StaticDB.Feedbacks;
        }

        public Feedback GetById(int id)
        {
            return StaticDB.Feedbacks.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Feedback entity)
        {
            StaticDB.Feedbacks.Add(entity);
            return entity.Id;
        }

        public void Update(Feedback entity)
        {

            var coment = StaticDB.Feedbacks.FirstOrDefault(x => x.Id == entity.Id);

            if (coment != null)
            {
                var commentIndex = StaticDB.Feedbacks.IndexOf(coment);
                StaticDB.Feedbacks[commentIndex] = entity;

            }
        }

        public void DeleteById(int id)
        {
            var comment = StaticDB.Feedbacks.FirstOrDefault(x => x.Id == id);
            StaticDB.Feedbacks.Remove(comment);
        }
    }
}
