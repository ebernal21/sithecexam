using SithecExamErickBernal.Data;
using SithecExamErickBernal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SithecExamErickBernal.Services
{
    public class HumanService : IHumanService
    {
        private readonly DatabaseContext _dbContext;
        public HumanService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<HumanModel> GetAllHumans()
        {
            return _dbContext.Humans.ToList();
        }
        public HumanModel AddHuman(HumanModel product)
        {
            var result = _dbContext.Humans.Add(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public HumanModel GetHumanById(int id)
        {
            return _dbContext.Humans.Where(x => x.id == id).FirstOrDefault();
        }

        public HumanModel UpdateHuman(HumanModel product)
        {
            var result = _dbContext.Humans.Update(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }
    }
}
