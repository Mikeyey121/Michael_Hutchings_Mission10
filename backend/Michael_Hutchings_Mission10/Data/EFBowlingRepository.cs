using Microsoft.EntityFrameworkCore;

namespace Michael_Hutchings_Mission10.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _context;
        public EFBowlingRepository(BowlingLeagueContext temp) { 
            _context = temp;
        }
        public IEnumerable<Bowler> Bowlers => _context.Bowlers;
        public IEnumerable<Team> Teams => _context.Teams;

        public IEnumerable<Bowler> GetAllBowlersWithTeams()
        {
            return _context.Bowlers.Include(b => b.Team)
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
                .ToArray();
        }

    }
}
