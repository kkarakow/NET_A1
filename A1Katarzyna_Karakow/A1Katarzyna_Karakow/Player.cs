namespace A1Katarzyna_Karakow
{        
    // PlyerType enum to represent different types of players
    public enum PlayerType
         {
             HockeyPlayer,
             BasketballPlayer,
             BaseballPlayer
         }
    // Parent abstract class 
    public abstract class Player
    {
        // Common fields to all players
        private PlayerType _playerType;
        private int _playerId;
        private string _playerName;
        private string _teamName;
        private int _gamesPlayed;
        
        public PlayerType PlayerType
        {
            get => _playerType;
            set => _playerType = value;
        }
        public int PlayerId
        {
            get => _playerId;
            set => _playerId = value;
        }
        public string PlayerName
        {
            get => _playerName;
            set => _playerName = value;
        }
        public string TeamName
        {
            get => _teamName;
            set => _teamName = value;
        }
        public int GamesPlayed
        {
            get => _gamesPlayed;
            set => _gamesPlayed = value;
        }
        
        // Player constrictor
        public Player(PlayerType playerType, int playerId, 
            string playerName, string teamName, int gamesPlayed)
        {
            PlayerType = playerType;
            PlayerId = playerId;
            PlayerName = playerName;
            TeamName = teamName;
            GamesPlayed = gamesPlayed;

        }
        // Abstract method declaration, which will be overridden in the derived classes
        public abstract int Points();
        
        // ToString method to format output
        public override string ToString()
        {
            return $"{PlayerType, 10}" +
                   $"{PlayerId, 10}" +
                   $"{PlayerName, 10}" +
                   $"{TeamName, 10}" +
                   $"{GamesPlayed, 10}";
        }
    }
}