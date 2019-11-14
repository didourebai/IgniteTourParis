using ConferenceManager.Entities.Models;
using ConferenceManager.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIs.Controllers
{
    //[Route("v1/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class StatisticsController: ControllerBase
    {
        private readonly IStatisticsRepo repo;

        public StatisticsController(IStatisticsRepo repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public StatisticsModel Get()
        {
            return repo.GetStatistics();
        }
    }
}
