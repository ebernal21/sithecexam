using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SithecExamErickBernal.Models;
using SithecExamErickBernal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SithecExamErickBernal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HumanController : ControllerBase
    {
        private readonly IHumanService humanService;
        public HumanController(IHumanService _humanService)
        {
            humanService = _humanService;
        }

        [HttpGet("getallhumansmock")]
        public IEnumerable<HumanModel> GetAllHumansMock()
        {
            return HumanModel.HumanMock.GetHumans();
        }

        [HttpGet("humanlist")]
        public IEnumerable<HumanModel> HumanList()
        {
            var humans = humanService.GetAllHumans();
            return humans;
        }

        [HttpPost("addhuman")]
        public HumanModel AddHuman(HumanModel human)
        {
            return humanService.AddHuman(human);
        }

        [HttpGet("gethumanbyid")]
        public HumanModel GetHumanById(int Id)
        {
            return humanService.GetHumanById(Id);
        }

        [HttpPut("updatehuman")]
        public HumanModel UpdateHuman(HumanModel human)
        {
            return humanService.UpdateHuman(human);
        }
    }
}
