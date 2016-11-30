using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Drawing;

using System.ComponentModel;  // for BindingList.

namespace SharedGameClasses {
    /// <summary>
    /// Plays a game called Hare and the Tortoise
    /// </summary>
    public static class HareAndTortoiseGame {
        
        // Minimum and maximum players per game
        private const int MIN_PLAYERS = 2;
        public const int MAX_PLAYERS = 6;

        // The dice
        private static Die die1 = new Die(), die2 = new Die();

        // A BindingList is like an array that can grow and shrink. 
        // 
        // Using a BindingList will make it easier to implement the GUI with a DataGridView
        private static BindingList<Player> players = new BindingList<Player>();
        public static BindingList<Player> Players {
            get {
                return players;
            }
        }

        
        private static int numberOfPlayers = 6;  // The value 6 is purely to avoid compiler errors.

        public static int NumberOfPlayers {
            get {
                return numberOfPlayers;
            }
            set {
                numberOfPlayers = value;
            }
        }

        // Is the current game finished?
        private static bool finished = false;
        public static bool Finished {
            get {
                return finished;
            }
        }

        /// Some default player names.  
        /// 
        /// These are purely for testing purposes and when initialising the players at the start
        /// 
        /// These values are intended to be read-only.  I.e. the program code should never update this array.
        private static string[] defaultNames = { "One", "Two", "Three", "Four", "Five", "Six" };

        // Some colours for the players' tokens (or "pieces"). 
        private static Brush[] playerTokenColours = new Brush[MAX_PLAYERS] { Brushes.Black, Brushes.Red, 
                                                              Brushes.Gold, Brushes.GreenYellow, 
                                                              Brushes.Fuchsia, Brushes.White };

                

        /// <summary>
        /// Initialises each of the players and adds them to the players BindingList.
        /// This method is called only once, when the game first startsfrom HareAndTortoiseForm.
        ///
        /// Pre:  none.
        /// Post: all the game's players are initialised.
        /// </summary>
        public static void InitialiseAllThePlayers() {

            //##################### Code needs to be added here. ############################################################
            for(int i=0; i< HareAndTortoiseGame.NumberOfPlayers; i++ ) {
                players.Add(new Player(defaultNames[i], Board.StartSquare));
                players[i].PlayerTokenColour = playerTokenColours[i];
                players[i].Money = 100;
                players[i].Location = Board.StartSquare;
            } 

            
        } // end InitialiseAllThePlayers

        /// <summary>
        /// Puts all the players on the Start square.
        /// Pre:  none.
        /// Post: the game is reset as though it is being played for the first time.
        /// </summary>
        public static void SetPlayersAtTheStart() {

            //##################### Code needs to be added here. ############################################################
            for(int i = 0;i < HareAndTortoiseGame.numberOfPlayers;i++) //&& i>MIN_PLAYERS-1; i++){
            {
                players[i].Location = Board.StartSquare;
                players[i].Origin_Location = Board.StartSquare;
                players[i].PlayerTokenColour = playerTokenColours[i];
            }
        } // end SetPlayersAtTheStart

        /// <summary>
        /// PlayOneRound, calls the Play method of Player class for each player.
        /// Pre:  none.
        /// Post: Each player has the play method called.
        /// </summary>
        public static void PlayOneRound() //################################################################
        {
            for(int i = 0;i < numberOfPlayers;i++)
            {
                    players[i].Play(die1,die2); // gets the total value after rolling the dice
                    players[i].Location.LandOn(players[i]);

                    players[i].Position = die1.FaceValue + die2.FaceValue;

                    if (players[i].Location.Number >= 40) {
                        SelectWinners();
                    }
                    //Debug.WriteLine("Player {0} position is now {1}", i, players[i].Position);
            }//end for
        } // end PlayOneRound


        /// <summary>
        /// A round for a single player individually.
        /// pre: the player's number
        /// post: the player is sent to the next location according to the dice value
        /// </summary>
        /// <param name="active_player">= 0 or a positive number</param>
        public static void EachPlayOneRound(int active_player) //####################
        {
            
                players[active_player].Play(die1,die2);
                players[active_player].Location.LandOn(players[active_player]);

                players[active_player].Position = die1.FaceValue + die2.FaceValue;

                if(players[active_player].Location.Number >= 40)
                {
                    SelectWinners();
                }//end if
              
        } // end PlayOneRound

       
        /// <summary>
        /// Finds the maximum amount of money among the players.
        /// pre: none
        /// post: determines the top amount of money a player has in comparison to others
        /// </summary>
        /// <returns></returns>
        public static int highestValue() //##########################################
        {
            int highest_amount = 0;

            for(int i = 0;i < numberOfPlayers;i++)
            {
                if(players[i].Money > highest_amount)
                {
                    highest_amount = players[i].Money;
                }

                if(i == numberOfPlayers) {
                    return highest_amount;
                }//end if
            }//end for

            return highest_amount;

        }//end method


        /// <summary>
        /// Gives winner title to any player with most money by setting the Player's Winner
        /// attribute to true after checking which player has the highest amount.
        /// pre: none
        /// post: the winner or winners are selected as a result the Winner attribute of the
        ///       player or players is set to true 
        /// </summary>
        
        public static void SelectWinners() //######################################
        {
            int winning_amount = highestValue();

            for(int i = 0;i < numberOfPlayers;i++)
            {
                if(players[i].Money == winning_amount)
                {
                    players[i].Winner = true;
                }//end if
            }//end for
        }//end method







    } //end class HareAndTortoiseGame
}
