namespace A1Katarzyna_Karakow
{
    public class BaseballPlayer : Player
    {
        // Baseball Player fields
        private int _runs;
        private int _homeRuns;

        public int Runs
        {
            get => _runs;
            set => _runs = value;
        }
        public int HomeRuns
        {
            get => _homeRuns;
            set => _homeRuns = value;
        }
        
        // Baseball Player constructor
        public BaseballPlayer(PlayerType playerType, int playerId, string playerName, 
            string teamName, int gamesPlayed, int runs, int homeRuns) 
            : base(playerType, playerId, playerName, teamName, gamesPlayed)
        {
            Runs = runs;
            HomeRuns = homeRuns;
        }
        
        /* Override Points method - calculate Baseball Player points:
            1 point for each run (minus any home runs)
            2 points for each home run
         */
        public override int Points()
        {
            return ((Runs - HomeRuns) + (2 * HomeRuns));
        }
        
        // ToString method
        public override string ToString()
        {
            return base.ToString() + 
                   $"\t{Runs, 10}" +
                   $"\t{HomeRuns, 10}" +
                   $"\t{Points(), 10}";
        }
    }
}