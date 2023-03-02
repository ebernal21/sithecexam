using SithecExamErickBernal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SithecExamErickBernal.Services
{
    public interface IHumanService
    {
        public IEnumerable<HumanModel> GetAllHumans();
        public HumanModel AddHuman(HumanModel human);
        public HumanModel GetHumanById(int id);
        public HumanModel UpdateHuman(HumanModel human);
    }
}
