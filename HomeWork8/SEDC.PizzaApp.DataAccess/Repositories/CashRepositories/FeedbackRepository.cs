using SEDC.PizzaApp.DomainModels.Models;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.DataAccess.Repositories.CashRepositories
{
    public class FeedbackRepository : IRepository<Feedback>
    {

        public List<Feedback> GetAll()
        {
            return StaticDb.Feedbacks;
        }

        public Feedback GetById(int id)
        {
            return StaticDb.Feedbacks.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Feedback entity)
        {

            StaticDb.Feedbacks.Add(entity);
            return entity.Id;

        }

        public void Update(Feedback entity)
        {
            var comment = StaticDb.Feedbacks.FirstOrDefault(x => x.Id == entity.Id);
            if (comment != null)
            {
                var commentIndex = StaticDb.Feedbacks.IndexOf(comment);
                StaticDb.Feedbacks[commentIndex] = entity;
            }
        }

        public void DeleteById(int id)
        {
            var comment = StaticDb.Feedbacks.FirstOrDefault(x => x.Id == id);
            StaticDb.Feedbacks.Remove(comment);
        }

    }
}
