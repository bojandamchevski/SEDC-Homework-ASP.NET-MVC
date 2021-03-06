using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Implementations
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        public void DeleteById(int id)
        {
            Feedback feedback = StaticDb.Feedbacks.FirstOrDefault(x => x.Id == id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }
            StaticDb.Feedbacks.Remove(feedback);
        }

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
            entity.Id = StaticDb.Feedbacks.Last().Id + 1;
            StaticDb.Feedbacks.Add(entity);
            return entity.Id;
        }

        public void Update(Feedback entity)
        {
            Feedback feedback = StaticDb.Feedbacks.FirstOrDefault(x => x.Id == entity.Id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {entity.Id} was not found");
            }
            int index = StaticDb.Feedbacks.IndexOf(feedback);
            StaticDb.Feedbacks[index] = entity;
        }
    }
}
