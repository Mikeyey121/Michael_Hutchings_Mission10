using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Michael_Hutchings_Mission10.Data;
using Microsoft.EntityFrameworkCore;

// This is our controller. This allows us to use the repository pattern and return a json object from the database. 
namespace Michael_Hutchings_Mission10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;

        public BowlingLeagueController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }
        // This is the get method to ultimately be called by our react app. 
        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlingData = _bowlingRepository.GetAllBowlersWithTeams();
            return bowlingData;
        }
    }

}
