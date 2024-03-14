namespace Michael_Hutchings_Mission10.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }

        IEnumerable<Bowler> GetAllBowlersWithTeams();
    }
}
