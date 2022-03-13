using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data.Services
{
    public class CreateSurveyService : CreateSurvey
    {
        private readonly AppDbContext _context;
        public CreateSurveyService( AppDbContext context) 
        {
            _context = context;
        }
        public void add(Question question)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Question>> GetAll()
        {
            var result = await _context.Question.ToListAsync();
            return result;
        }

        public Question GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Question Update(int id, Question newQuestion)
        {
            throw new NotImplementedException();
        }
    }
}
