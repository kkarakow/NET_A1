using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using static System.Int32;

namespace A1Katarzyna_Karakow
{
    class Program
    {
        // Generic Collection for all players
        private static List<Player> players = new List<Player>();
        
        // Add unique ID and increment it with every new player
        private static int uid = 1;

        static void Main(string[] args)
        {
            // Populate players Generic Collection with sample data when the program runs
            // Hockey Players
            Player hockeyP1 = new HockeyPlayer(PlayerType.HockeyPlayer, uid++, 
                "Connor McDavid", "Edmonton Oilers", 46, 63, 34);
            players.Add(hockeyP1);
            Player hockeyP2 = new HockeyPlayer(PlayerType.HockeyPlayer, uid++, 
                "Nathan MacKinnon", "Colorado Avalanche", 53, 58, 35);
            players.Add(hockeyP2);
            Player hockeyP3 = new HockeyPlayer(PlayerType.HockeyPlayer, uid++, 
                "Leon Draisaitl", "Edmonton Oilers", 153, 67, 43);
            players.Add(hockeyP3);
            Player hockeyP4 = new HockeyPlayer(PlayerType.HockeyPlayer, uid++, 
                "Artemi Panarin", "New York Rangers", 54, 63, 32);
            players.Add(hockeyP4);
            Player hockeyP5 = new HockeyPlayer(PlayerType.HockeyPlayer, uid++, 
                "Sidney Crosby", "Pittsburgh Penguins", 41, 31, 16);
            players.Add(hockeyP5);
            
            // Basketball Players
            Player basketballP1 = new BasketballPlayer(PlayerType.BasketballPlayer, uid++, 
                "Giannis Antetokounmpo", "Milwaukee Bucks", 56, 50, 15);
            players.Add(basketballP1);
            Player basketballP2 = new BasketballPlayer(PlayerType.BasketballPlayer, uid++, 
                "Kevin Durant", "Brooklyn Nets", 52, 34, 17);
            players.Add(basketballP2);
            Player basketballP3 = new BasketballPlayer(PlayerType.BasketballPlayer, uid++, 
                "LeBron James", "Los Angeles Lakers", 48, 42, 19);
            players.Add(basketballP3);
            Player basketballP4 = new BasketballPlayer(PlayerType.BasketballPlayer, uid++, 
                "Stephen Curry", "Golden State Warriors", 44, 32, 12);
            players.Add(basketballP4);
            Player basketballP5 = new BasketballPlayer(PlayerType.BasketballPlayer, uid++, 
                "Nikola Jokic", "Denver Nuggets", 34, 42, 16);
            players.Add(basketballP5);
            
            // Baseball Players
            Player baseballP1 = new BaseballPlayer(PlayerType.BaseballPlayer, uid++, 
                "Shohei Ohtani", "Angels", 42, 24, 15);
            players.Add(baseballP1);
            Player baseballP2 = new BaseballPlayer(PlayerType.BaseballPlayer, uid++, 
                "Fernando Tatis", "Padres", 40, 22, 12);
            players.Add(baseballP2);
            Player baseballP3 = new BaseballPlayer(PlayerType.BaseballPlayer, uid++, 
                "Vladimir Guerrero", "Blue Jays", 38, 20, 10);
            players.Add(baseballP3);
            Player baseballP4 = new BaseballPlayer(PlayerType.BaseballPlayer, uid++, 
                "Ronald Acuna", "Braves", 36, 18, 8);
            players.Add(baseballP4);
            Player baseballP5 = new BaseballPlayer(PlayerType.BaseballPlayer, uid++, 
                "Aaron Judge", "Yankees", 34, 16, 6);
            players.Add(baseballP5);

            // Show Menu
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            } // end of while loop
        } // end of Main
        
        // Main Menu
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine(
                "\t1 - Add Player\n" +
                "\t2 - Edit Player\n" +
                "\t3 - Delete Player\n" +
                "\t4 - View Players\n" +
                "\t5 - Search Player\n" +
                "\t6 - Exit\n");
            
            Console.WriteLine("Select menu option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    AddPlayer();
                    return false;
                case "2":
                    Console.Clear();
                    EditPlayer();
                    return false;
                case "3":
                    Console.Clear();
                    DeletePlayer();
                    return false;
                case "4":
                    Console.Clear();
                    ViewAllPlayers();
                    return false;
                case "5":
                    Console.Clear();
                    SearchPlayer();
                    return false;
                case "6":
                    Console.Clear();
                    Console.WriteLine("\n\tApplication Closed");
                    return false;
                default:
                    Console.WriteLine("Invalid input\nTry again\n");
                    return true;
            } // end of switch 
        } // end of MainMenu
        
        // View All Players
        private static void ViewAllPlayers(){
            Console.WriteLine("All Players:\n");
            Console.WriteLine("\nHockey Players:\n");
            ViewPlayer(PlayerType.HockeyPlayer);
            Console.WriteLine("\nBasketball Players:\n");
            ViewPlayer(PlayerType.BasketballPlayer);
            Console.WriteLine("\nBaseball Players:\n");
            ViewPlayer(PlayerType.BaseballPlayer);
            // Go Back to Main Menu
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            MainMenu();
        } // end of ViewAllPlayers
        
        // View Players Base on Player Type
        static void ViewPlayer(PlayerType playerType)
        {
            // Hockey Players
            var hockeyPlayers = from player in players
                where player.PlayerType == PlayerType.HockeyPlayer
                select player;
            
            // Basketball Players
            var basketballPlayers = from player in players
                where player.PlayerType == PlayerType.BasketballPlayer
                select player;
            
            // Baseball Players
            var baseballPlayers = from player in players
                where player.PlayerType == PlayerType.BaseballPlayer
                select player;

            switch (playerType)
            {
                // Hockey Player
                case PlayerType.HockeyPlayer:
                {
                    Console.WriteLine("All Hockey Players:\n");
                    Console.WriteLine($"" +
                                      $"{"Player Id", 10}" +
                                      $"{"Player Type", 10}" +
                                      $"{"Player Name", 10}" +
                                      $"{"Team Name", 10}" +
                                      $"{"Games Played", 10}" +
                                      $"\t{"Assists", 10}" +
                                      $"\t{"Goals", 10}" +
                                      $"\t{"Points", 10}\n");

                    foreach (var player in hockeyPlayers)
                    {
                        Console.WriteLine(player);
                    } // end of foreach loop
                    break;
                }
                // Basketball Player
                case PlayerType.BasketballPlayer:
                {
                    Console.WriteLine("All Basketball Players:\n");
                    Console.WriteLine($"" +
                                      $"{"Player Id", 10}" +
                                      $"{"Player Type", 10}" +
                                      $"{"Player Name", 10}" +
                                      $"{"Team Name", 10}" +
                                      $"{"Games Played", 10}" +
                                      $"\t{"Field Goals", 10}" +
                                      $"\t{"Three Pointers", 10}" +
                                      $"\t{"Points", 10}\n");

                    foreach (var player in basketballPlayers)
                    {
                        Console.WriteLine(player);
                    } // end of foreach loop
                    break;
                }
                // Baseball Player
                case PlayerType.BaseballPlayer:
                {
                    Console.WriteLine("All Baseball Players:\n");
                    Console.WriteLine($"" +
                                      $"{"Player Id", 10}" +
                                      $"{"Player Type", 10}" +
                                      $"{"Player Name", 10}" +
                                      $"{"Team Name", 10}" +
                                      $"{"Games Played", 10}" +
                                      $"\t{"Runs", 10}" +
                                      $"\t{"Home Runs", 10}" +
                                      $"\t{"Points", 10}\n");

                    foreach (var player in baseballPlayers)
                    {
                        Console.WriteLine(player);
                    } // end of foreach loop
                    break;
                }
                default:
                    Console.WriteLine("Invalid input\nTry again\n");
                    break;
            } // end of switch
        } // end of ViewPlayer
        
        // Add player 
        private static Player AddPlayer()
        {
            Console.WriteLine("Add New Player\n");
            // Choose Player Type
            Console.WriteLine(
                "\t1 - Add Hockey Player\n" +
                "\t2 - Add Basketball Player\n" +
                "\t3 - Add Baseball Player\n" +
                "\t4 - Back to Main Menu\n");

            PlayerType playerType = PlayerType.HockeyPlayer;
            
            // Show menu
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = AddMenu();
            }
            
            // AddMenu
            bool AddMenu()
            {
                Console.WriteLine("\nSelect Player Type: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        playerType = PlayerType.HockeyPlayer;
                        Console.WriteLine("\nAdd Hockey Player Details: ");
                        AddPlayerDetails(playerType);
                        return false;
                    case "2":
                        playerType = PlayerType.BasketballPlayer;
                        Console.WriteLine("\nAdd Basketball Player Details: ");
                        AddPlayerDetails(playerType);
                        return false;
                    case "3":
                        playerType = PlayerType.BaseballPlayer;
                        Console.WriteLine("\nAdd Baseball Player Details: ");
                        AddPlayerDetails(playerType);
                        return false;
                    case "4":
                        Console.Clear();
                        MainMenu();
                        return false;
                    default:
                        Console.WriteLine("Invalid input\nTry again\n");
                        return true;
                } // end of switch
            } // end of AddMenu()
            
        // AddingPlayerDetails()
        static void AddPlayerDetails(PlayerType playerType)
        {
            // HockeyPlayer Fields
            var assists = 0;
            var goals = 0;
            
            // Basketball Player Fields
            var fieldGoals = 0;
            var threePointers = 0;
            
            // Baseball Player Fields
            var runs = 0;
            var homeRuns = 0;

            // Validate input
            var isValid = true;
            
            // Enter Player Details
            Console.WriteLine("\nEnter Player Name: ");
            var playerName = Console.ReadLine();
            Console.WriteLine("\nEnter Team Name: ");
            var teamName = Console.ReadLine();

            // Validate if number of games played is more than or equal 0,
            // player cannot play negative number of games
            var gamesPlayed = 0;
            while (isValid)
            {
                Console.WriteLine("Enter Number of Games Played: ");
                var success = TryParse(Console.ReadLine(), out gamesPlayed);
                if (success && gamesPlayed >= 0)
                {
                    isValid = false;
                }
                else
                {
                    Console.WriteLine("Invalid input\nTry again\n");
                }
            } // end of gamesPlayed

            switch (playerType)
            {
                // Hockey Player
                case PlayerType.HockeyPlayer:
                {
                    isValid = true;
                    while (isValid)
                    {
                        Console.WriteLine("Enter Number of Player Assists: ");
                        var success = TryParse(Console.ReadLine(), out assists);
                        if (success && assists >= 0)
                        {
                            isValid = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input\nTry again\n");
                        }
                    }
            
                    // HockeyPlayer Goals
                    isValid = true;
                    while (isValid)
                    {
                        Console.WriteLine("Enter Hockey Player Goals: ");
                        var success = TryParse(Console.ReadLine(), out goals);
                        if (success && goals >= 0)
                        {
                            isValid = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input\nTry again\n");
                        }
                    } // end of while loop
            
                    // Create Hockey Player 
                    Player newHockeyPlayer = new HockeyPlayer(playerType, uid++, 
                        playerName, teamName, gamesPlayed, assists, goals);
            
                    // Add Hockey Player to Generic Collection
                    players.Add(newHockeyPlayer); 
                    break;
                }
                // Basketball Player Field Goals
                case PlayerType.BasketballPlayer:
                {
                    isValid = true;
                    while (isValid)
                    {
                        Console.WriteLine("Enter Number of Player Field Goals: ");
                        var success = TryParse(Console.ReadLine(), out fieldGoals);
                        if (success && fieldGoals >= 0)
                        {
                            isValid = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input\nTry again\n");
                        }
                    }
                    // Basketball Player Three Pointers
                    isValid = true;
                    while (isValid)
                    {
                        Console.WriteLine("Enter Basketball Player Three Pointers: ");
                        var success = TryParse(Console.ReadLine(), out threePointers);
                        if (success && threePointers >= 0)
                        {
                            isValid = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input\nTry again\n");
                        }
                    }
                    // Create Basketball Player 
                    Player newBasketballPlayer = new BasketballPlayer(playerType, uid++, 
                        playerName, teamName, gamesPlayed, fieldGoals, threePointers);
                    // Add Hockey Player to Generic Collection
                    players.Add(newBasketballPlayer); 
                    break;
                }
                // Baseball Player Runs
                case PlayerType.BaseballPlayer:
                {
                    isValid = true;
                    while (isValid)
                    {
                        Console.WriteLine("Enter Number of Baseball Player Runs: ");
                        var success = TryParse(Console.ReadLine(), out runs);
                        if (success && runs >= 0)
                        {
                            isValid = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input\nTry again\n");
                        }
                    }
                
                    // Baseball Player Home Runs
                    isValid = true;
                    while (isValid)
                    {
                        Console.WriteLine("Enter Baseball Player Home Runs: ");
                        var success = TryParse(Console.ReadLine(), out homeRuns);
                        if (success && homeRuns >= 0)
                        {
                            isValid = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input\nTry again\n");
                        }
                    }
                    // Create Baseball Player 
                    Player newBaseballPlayer = new BaseballPlayer(playerType, uid++, 
                        playerName, teamName, gamesPlayed, runs, homeRuns);
                    // Add Hockey Player to Generic Collection
                    players.Add(newBaseballPlayer); 
                    break;
                }
                default:
                    Console.WriteLine("Invalid input\nTry again\n");
                    break;
            } // end of switch
            
            Console.WriteLine("\n New Player Added");
            Console.WriteLine("\nView All Players");
            ViewPlayer(playerType);
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
            // Back to Add Player Menu
            AddPlayer();
        } // end of AddPlayerDetails
        
        return null;
        
        } // end of AddPlayer() 
        
        // Edit Players
        private static Player EditPlayer()
        {
            Console.WriteLine("\nSelect Player Type to Edit: ");
            Console.WriteLine(
                "\t 1 - Edit Hockey Player\n" +
                "\t 2 - Edit Basketball Player\n" +
                "\t 3 - Edit Baseball Player\n" +
                "\t 4 - Back to Main Menu\n");

            PlayerType playerType = PlayerType.HockeyPlayer;

            // Show Menu
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = EditMenu();
            }
            
            // Edit Menu
            bool EditMenu()
            {
                Console.WriteLine("\nSelect Player Type: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        playerType = PlayerType.HockeyPlayer;
                        Console.WriteLine("\nEdit Hockey Player Details: ");
                        EditPlayerDetails(playerType);
                        return false;
                    case "2":
                        playerType = PlayerType.BasketballPlayer;
                        Console.WriteLine("\nEdit Basketball Player Details: ");
                        EditPlayerDetails(playerType);
                        return false;
                    case "3":
                        playerType = PlayerType.BaseballPlayer;
                        Console.WriteLine("\nEdit Baseball Player Details: ");
                        EditPlayerDetails(playerType);
                        return false;
                    case "4":
                        Console.Clear();
                        MainMenu();
                        return false;
                    default:
                        Console.WriteLine("Invalid input\nTry again\n");
                        return true;
                } // end of switch
            } // end of EditMenu()
            
            // EditPlayerDetails
            static void EditPlayerDetails(PlayerType playerType)
            {
                ViewPlayer(playerType);
                while (true)
                {
                    Console.WriteLine("Enter Player ID to Edit Player:\n");
                    var pid = Convert.ToInt32(Console.ReadLine());
                    
                if (pid > 0 && pid < players.Count)
                    {
                        if (players[pid - 1].PlayerType == playerType)
                        {
                            // HockeyPlayer Fields
                            var assists = 0;
                            var goals = 0;

                            // Basketball Player Fields
                            var fieldGoals = 0;
                            var threePointers = 0;

                            // Baseball Player Fields
                            var runs = 0;
                            var homeRuns = 0;

                            // Validate input
                            var isValid = true;

                            // Enter player new details
                            Console.WriteLine("\nEnter Player New Name:");
                            var playerName = Console.ReadLine();
                            Console.WriteLine("\nEnter Team New Name:");
                            var teamName = Console.ReadLine();

                            int gamesPlayed = 0;
                            while (isValid)
                            {
                                Console.WriteLine("Enter Number of Players Games: ");
                                var success = TryParse(Console.ReadLine(), out gamesPlayed);
                                if (success && gamesPlayed >= 0)
                                {
                                    isValid = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input\nTry again\n");
                                }
                            } // end of while loop

                            switch (playerType)
                            {
                                // Hockey Player
                                case PlayerType.HockeyPlayer:
                                {
                                    isValid = true;
                                    while (isValid)
                                    {
                                        Console.WriteLine("Enter Number of Player Assists: ");
                                        var success = TryParse(Console.ReadLine(), out assists);
                                        if (success && assists >= 0)
                                        {
                                            isValid = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input\nTry again\n");
                                        }
                                    }
                                    // HockeyPlayer Goals
                                    isValid = true;
                                    while (isValid)
                                    {
                                        Console.WriteLine("Enter Hockey Player Goals: ");
                                        var success = TryParse(Console.ReadLine(), out goals);
                                        if (success && goals >= 0)
                                        {
                                            isValid = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input\nTry again\n");
                                        }
                                    } // end of while loop
                                    
                                    players[pid - 1] = new HockeyPlayer(playerType, pid,
                                        playerName, teamName, gamesPlayed, assists, goals);
                                    break;
                                }
                                
                                // Basketball Player Field Goals
                                case PlayerType.BasketballPlayer:
                                {
                                    isValid = true;
                                    while (isValid)
                                    {
                                        Console.WriteLine("Enter Number of Player Field Goals: ");
                                        var success = TryParse(Console.ReadLine(), out fieldGoals);
                                        if (success && fieldGoals >= 0)
                                        {
                                            isValid = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input\nTry again\n");
                                        }
                                    }

                                    // Basketball Player Three Pointers
                                    isValid = true;
                                    while (isValid)
                                    {
                                        Console.WriteLine("Enter Basketball Player Three Pointers: ");
                                        var success = TryParse(Console.ReadLine(), out threePointers);
                                        if (success && threePointers >= 0)
                                        {
                                            isValid = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input\nTry again\n");
                                        }
                                    } // end of while loop
                                    players[pid - 1] = new BasketballPlayer(playerType, pid,
                                        playerName, teamName, gamesPlayed, fieldGoals, threePointers);
                                    break;
                                }
                                // Baseball Player Runs
                                case PlayerType.BaseballPlayer:
                                {
                                    isValid = true;
                                    while (isValid)
                                    {
                                        Console.WriteLine("Enter Number of Baseball Player Runs: ");
                                        var success = TryParse(Console.ReadLine(), out runs);
                                        if (success && runs >= 0)
                                        {
                                            isValid = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input\nTry again\n");
                                        }
                                    }

                                    // Baseball Player Home Runs
                                    isValid = true;
                                    while (isValid)
                                    {
                                        Console.WriteLine("Enter Baseball Player Home Runs: ");
                                        var success = TryParse(Console.ReadLine(), out homeRuns);
                                        if (success && homeRuns >= 0)
                                        {
                                            isValid = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input\nTry again\n");
                                        }
                                    }
                                    players[pid - 1] = new BaseballPlayer(playerType, pid,
                                        playerName, teamName, gamesPlayed, runs, homeRuns);
                                    break;
                                }
                                default:
                                    Console.WriteLine("Invalid input\nTry again\n");
                                    break;
                            } // end of switch
                            
                            Console.WriteLine("\nPress any key to continue");
                            Console.ReadKey();
                            Console.Clear();
                            // Back to Edit Player Menu
                            EditPlayer();
                        } // end of if statement
                    } // end of if statement
                } // end of while loop
            } // end of EditPlayerDetails
            return null;
        } // end of EditPlayer
        
        // Delete Player
        private static Player DeletePlayer()
        {
            Console.Clear();
            Console.WriteLine("Delete Player\n");
            Console.WriteLine(
                "\t 1 - Delete Hockey Player\n" +
                "\t 2 - Delete Basketball Player\n" +
                "\t 3 - Delete Baseball Player\n" +
                "\t 4 - Back to Main Menu\n");

            PlayerType playerType = PlayerType.HockeyPlayer;
            
            // Show Menu
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = DeleteMenu();
            }
            
            // Delete Menu
            bool DeleteMenu()
            {
                Console.WriteLine("\nSelect Player Type: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        playerType = PlayerType.HockeyPlayer;
                        Console.WriteLine("\nDelete Hockey Player Details: ");
                        DeletePlayerDetails(playerType);
                        return false;
                    case "2":
                        playerType = PlayerType.BasketballPlayer;
                        Console.WriteLine("\nDelete Basketball Player Details: ");
                        DeletePlayerDetails(playerType);
                        return false;
                    case "3":
                        playerType = PlayerType.BaseballPlayer;
                        Console.WriteLine("\nDelete Baseball Player Details: ");
                        DeletePlayerDetails(playerType);
                        return false;
                    case "4":
                        Console.Clear();
                        MainMenu();
                        return false;
                    default:
                        Console.WriteLine("Invalid input\nTry again\n");
                        return true;
                } // end of switch
            } // end of DeleteMenu

            static void DeletePlayerDetails(PlayerType playerType)
            {
                ViewPlayer(playerType);
                bool isValid = true;
                while (isValid)
                {
                    var uid = -1;
                    var pid = -1;
                    isValid = true;
                    while (true)
                    {
                        Console.WriteLine("Enter Player ID to Delete Player:\n");
                        var success = int.TryParse(Console.ReadLine(), out uid);
                        if (success)
                        {
                            isValid = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input\nTry again\n");
                        }// end of if-else statement
                        
                        pid = players.FindIndex(i => i.PlayerId == uid);

                        if (pid != -1)
                        {
                            if (players[pid].PlayerType == playerType)
                            {
                                players.RemoveAt(pid);
                                Console.WriteLine("Player Deleted");
                                Console.WriteLine("/nPress any key to continue");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input\nTry again\n");
                            }// end of if-else statement
                        } // end of if statement
                    } // end of while loop
                } // end of while loop
                DeletePlayer();
            } // end of DeletePlayerDetails
            return null;
        } // end of DeletePlayer
        
        // Search Player
        private static void SearchPlayer()
        {
            Console.WriteLine("Search Players");
            Console.WriteLine("\nEnter Player Name: ");
            var playerName = Console.ReadLine();

            var result = from player in players
                where player.PlayerName.Contains(playerName, StringComparison.OrdinalIgnoreCase)
                select player;

            if (result.Count() > 0)
            {
                Console.WriteLine($"\nSearch results: \n");
                foreach (var player in result)
                {
                    switch (player.PlayerType)
                    {
                        case PlayerType.HockeyPlayer:
                            Console.WriteLine("Hockey Players:\n");
                            Console.WriteLine($"" +
                                              $"{"Player Id", 10}" +
                                              $"{"Player Type", 10}" +
                                              $"{"Player Name", 10}" +
                                              $"{"Team Name", 10}" +
                                              $"{"Games Played", 10}" +
                                              $"\t{"Assists", 10}" +
                                              $"\t{"Goals", 10}" +
                                              $"\t{"Points", 10}\n");
                            Console.WriteLine(player); 
                            break;
                        case PlayerType.BasketballPlayer:
                            Console.WriteLine("Basketball Players:\n");
                            Console.WriteLine($"" +
                                              $"{"Player Id", 10}" +
                                              $"{"Player Type", 10}" +
                                              $"{"Player Name", 10}" +
                                              $"{"Team Name", 10}" +
                                              $"{"Games Played", 10}" +
                                              $"\t{"Field Goals", 10}" +
                                              $"\t{"Three Pointers", 10}" +
                                              $"\t{"Points", 10}\n");
                            Console.WriteLine(player); 
                            break;
                        case PlayerType.BaseballPlayer:
                            Console.WriteLine("All Baseball Players:\n");
                            Console.WriteLine($"" +
                                              $"{"Player Id", 10}" +
                                              $"{"Player Type", 10}" +
                                              $"{"Player Name", 10}" +
                                              $"{"Team Name", 10}" +
                                              $"{"Games Played", 10}" +
                                              $"\t{"Runs", 10}" +
                                              $"\t{"Home Runs", 10}" +
                                              $"\t{"Points", 10}\n");
                            Console.WriteLine(player); 
                            break;
                    }
                } // end of foreach loop
            } // end of if statement
        } // end of SearchPlayer
    } // end of Program Class
} // end of namespace