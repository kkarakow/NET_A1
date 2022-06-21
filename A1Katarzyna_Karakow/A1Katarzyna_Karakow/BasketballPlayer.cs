namespace A1Katarzyna_Karakow
{
    public class BasketballPlayer : Player
    {
        // Basketball Player fields
        private int _fieldGoals;
        private int _threePointers;

        public int FieldGoals
        {
            get => _fieldGoals;
            set => _fieldGoals = value;
        }
        public int ThreePointers
        {
            get => _threePointers;
            set => _threePointers = value;
        }
        
        // Basketball Player constructor
        public BasketballPlayer(PlayerType playerType, int playerId, string playerName, 
            string teamName, int gamesPlayed, int fieldGoals, int threePointers) 
            : base(playerType, playerId, playerName, teamName, gamesPlayed)
        {
            FieldGoals = fieldGoals;
            ThreePointers = threePointers;
        }

        /* Override Points method - calculate Basketball Player points:
            1 point for each field goal (minus any 3-pointers)
            2 points for each 3-pointer 
         */
        public override int Points()
        {
            return ((FieldGoals - ThreePointers) + (2 * ThreePointers));
        }
        
        // ToString method
        public override string ToString()
        {
            return base.ToString() + 
                   $"\t{FieldGoals, 10}" +
                   $"\t{ThreePointers, 10}" +
                   $"\t{Points(), 10}";
        }
    }
}