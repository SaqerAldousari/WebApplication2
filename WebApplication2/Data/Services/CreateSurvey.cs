using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data.Services
{
    public interface CreateSurvey
    {
        Task<IEnumerable<Question>> GetAll();
        Question GetById(int id);
        void add(Question question);
        Question Update(int id, Question newQuestion);
        void Delete(int id);
    }
}
