namespace A1Katarzyna_Karakow
{
    public class HockeyPlayer : Player
    {
        // HockeyPlayer fields
        private int _assists;
        private int _goals;

        public int Assists
        {
            get => _assists;
            set => _assists = value;
        }
        public int Goals
        {
            get => _goals;
            set => _goals = value;
        }
        
        // HockeyPlayer constructor
        public HockeyPlayer(PlayerType playerType, int playerId, string playerName,
            string teamName, int gamesPlayed, int assists, int goals) 
            : base(playerType, playerId, playerName, teamName, gamesPlayed)
        {
            Assists = assists;
            Goals = goals;
        }
        
        /* Override Points method - calculate the hockey player points:
            1 point for each assist
            2 points for each goal
         */
        public override int Points()
        {
            return Assists + (2 * Goals);
        }
        
        // ToString method
        public override string ToString()
        {
            return base.ToString() +
                   $"\t{Assists, 10}" +
                   $"\t{Goals, 10}" +
                   $"\t{Points(), 10}";
        }
    }
}