/*
 Hare and Tortoise game graphics class
 * Author: OHI AHMED
 * Student ID: n9023348
 * 
 * Author: Nor Nor 
 * Sudent ID: n9195351
 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Diagnostics;

using SharedGameClasses;

namespace GuiGame {

    /// <summary>
    /// The form that displays the GUI of the game named HareAndTortoise.
    /// </summary>
    public partial class HareAndTortoiseForm : Form {

        // Specify the numbers of rows and columns on the screen.
        const int NUM_OF_ROWS = 7;
        const int NUM_OF_COLUMNS = 6;

        // When we update what's on the screen, we show the movement of players 
        // by removing them from their old squares and adding them to their new squares.
        // This enum makes it clearer that we need to do both.
        enum TypeOfGuiUpdate { AddPlayer, RemovePlayer };
    
        /// <summary>
        /// Constructor with initialising parameters.
        /// Pre:  none.
        /// Post: the form is initialised, ready for the game to start.
        /// </summary>
        public HareAndTortoiseForm() {
            InitializeComponent();
            HareAndTortoiseGame.NumberOfPlayers = HareAndTortoiseGame.MAX_PLAYERS; // Max players, by default.
            Board.SetUpBoard();
            HareAndTortoiseGame.InitialiseAllThePlayers();
            SetupTheGui();
            HareAndTortoiseGame.SetPlayersAtTheStart();
            ResetGame();
        }

        /// <summary>
        /// Set up the GUI when the game is first displayed on the screen.
        /// 
        /// This method is almost complete. It should only be changed by adding one line:
        ///     to set the initial ComboBox selection to "6"; 
        /// 
        /// Pre:  the form contains the controls needed for the game.
        /// Post: the game is ready for the user(s) to play.
        /// </summary>
        private void SetupTheGui() {
            CancelButton = exitButton;  // Allow the Esc key to close the form.
            ResizeGameBoard();
            SetupGameBoard();

            //####################### set intitial ComboBox Seletion to 6 here ####################################
            comboBox1.Text = "6";
            SetupPlayersDataGridView();
            
              
        }// end SetupTheGui


        /// <summary>
        /// Resizes the entire form, so that the individual squares have their correct size, 
        /// as specified by SquareControl.SQUARE_SIZE.  
        /// This method allows us to set the entire form's size to approximately correct value 
        /// when using Visual Studio's Designer, rather than having to get its size correct to the last pixel.
        /// Pre:  none.
        /// Post: the board has the correct size.
        /// </summary>
        private void ResizeGameBoard() {

            // Uncomment all the lines in this method, once you've placed the boardTableLayoutPanel to your form.
            // Do not add any extra code.


            const int SQUARE_SIZE = SquareControl.SQUARE_SIZE;
            int currentHeight = boardTableLayoutPanel.Size.Height;
            int currentWidth = boardTableLayoutPanel.Size.Width;
            int desiredHeight = SQUARE_SIZE * NUM_OF_ROWS;
            int desiredWidth = SQUARE_SIZE * NUM_OF_COLUMNS;
            int increaseInHeight = desiredHeight - currentHeight;
            int increaseInWidth = desiredWidth - currentWidth;
            this.Size += new Size(increaseInWidth, increaseInHeight);
            boardTableLayoutPanel.Size = new Size(desiredWidth, desiredHeight);
        }

        /// <summary>
        /// Creates each SquareControl and adds it to the boardTableLayoutPanel that displays the board.
        /// Pre:  none.
        /// Post: the boardTableLayoutPanel contains all the SquareControl objects for displaying the board.
        /// </summary>
        /// 

        public SquareControl [] SquarePlay = new SquareControl[42];

        private void SetupGameBoard() {
            // ########################### Code needs to be written to perform the following  ###############################################
                  
            int x, y;
     
            for (int i = 0; i < 42; i++) {
                     
                SquarePlay[i] = new SquareControl(Board.Squares[i],HareAndTortoiseGame.Players);

                if(i == 0 || i == 41)
                {
                    SquarePlay[i].BackColor = Color.BurlyWood;
                    
                    
                }//end if

                MapSquareNumToScreenRowAndColumn(i,out x,out y);
                boardTableLayoutPanel.Controls.Add(SquarePlay[i],x,y);
            }//end for

            

           //boardTableLayoutPanel.Controls.Add(HareAndTortoiseGame.Players[1]);

            
         

            //}
            /*
             *   taking each Square of Baord separately create a SquareContol object containing that Square (look at the Constructor for SquareControl)
             *   
             *   when it is either the Start Square or the Finish Square set the BackColor of the SquareControl to BurlyWood
             *   
             *   DO NOT set the BackColor of any other Square Control 
             * 
             *   Call MapSquareNumtoScreenRowAnd Column  to determine the row and column position of the SquareControl on the TableLayoutPanel
             *   
             *   Add the Control to the TaleLayoutPanel
             * 
             */

        }// SetupGameBaord


        /// <summary>
        /// Tells the players DataGridView to get its data from the hareAndTortoiseGame.Players BindingList.
        /// Pre:  players DataGridView exists on the form.
        ///       HareAndTortoiseGame.Players BindingList is not null.
        /// Post: players DataGridView displays the correct rows and columns.
        /// </summary>
        private void SetupPlayersDataGridView() {

            // ########################### Code needs to be written  ###############################################
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = HareAndTortoiseGame.Players;
        }//SetupPlayersDataGridView


        /// <summary>
        /// Resets the game, including putting all the players on the Start square.
        /// This requires updating what is displayed in the GUI, 
        /// as well as resetting the attrtibutes of HareAndTortoiseGame .
        /// This method is used by both the Reset button and 
        /// when a new value is chosen in the Number of Players ComboBox.
        /// Pre:  none.
        /// Post: the form displays the game in the same state as when the program first starts 
        ///       (except that any user names that the player has entered are not reset).
        /// </summary>
        private void ResetGame() //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        {

            // ########################### Code needs to be written  ###############################################
            try {// tries removing winner from all the 6(max) players but if its less than 6, removes 
                 // them and catches exception, ignores it and then continues reset
                for (int i = 0; i < HareAndTortoiseGame.MAX_PLAYERS; i++) {
                    HareAndTortoiseGame.Players[i].Winner = false;
                }
            } catch (Exception) { ContinueReset(); }
           
            ContinueReset();

        }//end ResetGame
        
        private void ContinueReset() { // just the other parts of reseting the game
            UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
            HareAndTortoiseGame.SetPlayersAtTheStart();
            UpdatePlayersGuiLocations(TypeOfGuiUpdate.AddPlayer);
            HareAndTortoiseGame.InitialiseAllThePlayers();
            SetupPlayersDataGridView();

            resetButton.Enabled = false;

            gbSingleStep.Visible = true;
            rbtYes.Checked = false;
            rbtNo.Checked = false;

            btnSingleStep.Visible = false;
            rollDiceButton.Visible = false;
            btnSingleStep.Enabled = true;
        }
                   
        /// <summary>
        /// At several places in the program's code, it is necessary to update the GUI board,
        /// so that player's tokens (or "pieces") are removed from their old squares
        /// or added to their new squares. E.g. when all players are moved back to the Start.
        /// 
        /// For each of the players, this method is to use the GetSquareNumberOfPlayer method to find out 
        /// which square number the player is on currently, then use the SquareControlAt method
        /// to find the corresponding SquareControl, and then update that SquareControl so that it
        /// knows whether the player is on that square or not.
        /// 
        /// Moving all players from their old to their new squares requires this method to be called twice: 
        /// once with the parameter typeOfGuiUpdate set to RemovePlayer, and once with it set to AddPlayer.
        /// In between those two calls, the players locations must be changed by using one or more methods 
        /// in the HareAndTortoiseGame class. Otherwise, you won't see any change on the screen.
        /// 
        /// Because this method moves ALL players, it should NOT be used when animating a SINGLE player's
        /// movements from square to square.
        /// 
        /// 
        /// Post: the GUI board is updated to match the locations of all Players objects.
        /// </summary>
        /// <param name="typeOfGuiUpdate">Specifies whether all the players are being removed 
        /// from their old squares or added to their new squares</param>
        private void UpdatePlayersGuiLocations(TypeOfGuiUpdate typeOfGuiUpdate) {

            //##################### Code needs to be added here. ############################################################

           // int sqLocation;

            for (int i = 0; i < HareAndTortoiseGame.NumberOfPlayers; i++){

                int sqLocation = GetSquareNumberOfPlayer(i);
                
                if(typeOfGuiUpdate == TypeOfGuiUpdate.AddPlayer){
                 
                    SquarePlay[sqLocation].ContainsPlayers[i] = true;
                }
                else
                {
                    SquarePlay[sqLocation].ContainsPlayers[i] = false;
                }//end if

            }//end for

            RefreshBoardTablePanelLayout(); // Must be the last line in this method. DO NOT put it inside a loop.
            Application.DoEvents();
        }// end UpdatePlayersGuiLocations



        /*** START OF LOW-LEVEL METHODS *****************************************************************************
         * 
         *   The methods in this section are "helper" methods that can be called to do basic things. 
         *   That makes coding easier in other methods of this class.
         *   
         *   
         *   ********************************************************************************************************/

        /// <summary>
        /// When the SquareControl objects are updated (when players move to a new square),
        /// the board's TableLayoutPanel is not updated immediately.  
        /// Each time that players move, this method must be called so that the board's TableLayoutPanel 
        /// is told to refresh what it is displaying.
        /// Pre:  none.
        /// Post: the board's TableLayoutPanel shows the latest information 
        ///       from the collection of SquareControl objects in the TableLayoutPanel.
        /// </summary>
        private void RefreshBoardTablePanelLayout() {
            // ################# Uncomment the following line once you've placed the boardTableLayoutPanel on your form. ########################################
            boardTableLayoutPanel.Invalidate(true);
        }//end RefreshBoardTablePanelLayout


        /// <summary>
        /// When the Player objects are updated (location, money, etc.),
        /// the players DataGridView is not updated immediately.  
        /// Each time that those player objects are updated, this method must be called 
        /// so that the players DataGridView is told to refresh what it is displaying.
        /// Pre:  none.
        /// Post: the players DataGridView shows the latest information 
        ///       from the collection of Player objects in the HareAndTortoiseGame.
        /// </summary>
        private void RefreshPlayersInfoInDataGridView() {
            HareAndTortoiseGame.Players.ResetBindings();
        } //end RefreshPlayersInfoInDataGridView


        /// <summary>
        /// Tells you the current square number that a given player is on.
        /// Pre:  a valid playerNumber is specified.
        /// Post: returns the square number of the square the player is on.
        /// </summary>
        /// <param name="playerNumber">The player number.</param>
        /// <returns>Returns the square number of the playerNumber.</returns>
        private int GetSquareNumberOfPlayer(int playerNumber) {
            Square playerSquare = HareAndTortoiseGame.Players[playerNumber].Location;

            return playerSquare.Number;
        } //end GetSquareNumberOfPlayer


        /// <summary>
        /// Tells you which SquareControl object is associated with a given square number.
        /// Pre:  a valid squareNumber is specified; and
        ///       the boardTableLayoutPanel is properly constructed.
        /// Post: the SquareControl object associated with the square number is returned.
        /// </summary>
        /// <param name="squareNumber">The square number.</param>
        /// <returns>Returns the SquareControl object associated with the square number.</returns>
        private SquareControl SquareControlAt(int squareNumber) {
            int rowNumber;
            int columnNumber;
            MapSquareNumToScreenRowAndColumn(squareNumber, out rowNumber, out columnNumber);

            // Uncomment the following line once you've added the boardTableLayoutPanel to your form.
            return (SquareControl) boardTableLayoutPanel.GetControlFromPosition(columnNumber, rowNumber);

            // Delete the following line once you've added the boardTableLayoutPanel to your form.
        } //end SquareControlAt


        /// <summary>
        /// For a given square number, tells you the corresponding row and column numbers.
        /// Pre:  none.
        /// Post: returns the row and column numbers, via "out" parameters.
        /// </summary>
        /// <param name="squareNumber">The input square number.</param>
        /// <param name="rowNumber">The output row number.</param>
        /// <param name="columnNumber">The output column number.</param>
        private static void MapSquareNumToScreenRowAndColumn(int squareNumber, out int rowNumber, out int columnNumber)
        {

            // ######################## Add more code to this method and replace the next two lines by something more sensible.  ###############################
            //rowNumber = 0;      // Use 0 to make the compiler happy for now.
            //columnNumber = 0;
            int i;
  
            if (36 <= squareNumber && squareNumber <= 41)
            {
                columnNumber = 0;
                rowNumber = squareNumber - 36;
            }else if (30 <= squareNumber && squareNumber <= 35)
            {
                columnNumber = 1;
                rowNumber = 35 - squareNumber;
            }else if (24 <= squareNumber && squareNumber <= 29)
            {
                columnNumber = 2;
                rowNumber = squareNumber - 24;
            } else if (18 <= squareNumber && squareNumber <= 23)
            {
                columnNumber = 3;
                int count = 0;

                for(i = 18; i < squareNumber; i++)
                {
                    count++;
                }//end for

                rowNumber = 5 - count;
                
            } else if (12 <= squareNumber && squareNumber <= 17)
            {
                columnNumber = 4;
                rowNumber = squareNumber - 12;
            } else if (6 <= squareNumber && squareNumber <= 11)
            {
                columnNumber = 5;
                rowNumber = 11 - squareNumber;            
            }
            else
            {
                columnNumber = 6;
                rowNumber = squareNumber;
            }//end if
  }
   

        /*** END OF LOW-LEVEL METHODS **********************************************/

        
        
        /*** START OF EVENT-HANDLING METHODS ***/
        // ####################### Place EVENT HANDLER Methods to this area of code  ##################################################
        /// <summary>
        /// Handle the Exit button being clicked.
        /// Pre:  the Exit button is clicked.
        /// Post: the game is closed.
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e) {
            // Terminate immediately, rather than calling Close(), 
            // so that we don't have problems with any animations that are running at the same time.
            Environment.Exit(0);  
        }

        private void resetButton_Click(object sender, EventArgs e) {
         
            ResetGame();
            gbSingleStep.Visible = true;
            resetButton.Enabled = false;
        }

        //##############################################################################################################################################
        private void rollDiceButton_Click(object sender,EventArgs e){
        
            rollDiceButton.Enabled = false;
            resetButton.Enabled = false;
            comboBox1.Enabled = false;
            UpdatePlayersGuiLocations(TypeOfGuiUpdate.AddPlayer);
            HareAndTortoiseGame.PlayOneRound();
            
            for (int i = 0; i < HareAndTortoiseGame.NumberOfPlayers; i++) {
                AnimateMovement(i);
            }//end for
            rollDiceButton.Enabled = true;
           
            for (int i = 0; i<HareAndTortoiseGame.NumberOfPlayers; i++){
                int sqLocation = GetSquareNumberOfPlayer(i);
                
                
                if (HareAndTortoiseGame.Players[i].Location.Number == Board.FINISH_SQUARE_NUMBER) {         
                    rollDiceButton.Enabled = false;
                } //end if
            }//end for

            SetupPlayersDataGridView();
            resetButton.Enabled = true;
            comboBox1.Enabled = true;
        }

       /// <summary>
       /// Puts the tokens from its current location to the location after dice roll but looping
       /// through all the squares in between the old and new location.
       /// Pre: the current player number
       /// Post: the current player number's token moves every square before the new location
       /// </summary>
       /// <param name="currentPlayer">current player's number</param>
        
        private void AnimateMovement(int currentPlayer){
        
            int start, end, i;

            start = HareAndTortoiseGame.Players[currentPlayer].Origin_Location.Number;
            end = HareAndTortoiseGame.Players[currentPlayer].Location.Number;

            for (i = start+1; i <= end; i++)
            {
                SquarePlay[i-1].ContainsPlayers[currentPlayer] = false;
                RefreshBoardTablePanelLayout();
                Application.DoEvents();

                SquarePlay[i].ContainsPlayers[currentPlayer] = true;
                RefreshBoardTablePanelLayout();
                Application.DoEvents();

            }//end for
            HareAndTortoiseGame.Players[currentPlayer].Origin_Location = Board.Squares[end];
        }//end AnimateMovement


        //number of players selection combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){
           
            UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
            HareAndTortoiseGame.NumberOfPlayers = int.Parse(comboBox1.Text);
            ResetGame();
            gbSingleStep.Visible = true;
            resetButton.Enabled = false;
            for(int i = 0; i < HareAndTortoiseGame.MAX_PLAYERS;i++)
            {
                HareAndTortoiseGame.Players[i].Money = 100;
            }//end for
        }

        //radio buttons Yes and No:
        private void rbtYes_CheckedChanged(object sender,EventArgs e){
            btnSingleStep.Visible = true;
            resetButton.Enabled = true;
            rollDiceButton.Visible = false;
            gbSingleStep.Visible = false;
        }


        private void rbtNo_CheckedChanged(object sender,EventArgs e){    
            rollDiceButton.Visible = true;
            rollDiceButton.Enabled = true;
            resetButton.Enabled = true;
            btnSingleStep.Visible = false;
            gbSingleStep.Visible = false;   
        }


        public int playerPlaying; //the number of a current player to play an individual round

        private void btnSingleStep_Click(object sender,EventArgs e){//button to move a single player
            
            btnSingleStep.Enabled = false;
            comboBox1.Enabled = false;
            resetButton.Enabled = false;

            if(playerPlaying < HareAndTortoiseGame.NumberOfPlayers)
            {
                HareAndTortoiseGame.EachPlayOneRound(playerPlaying);
                AnimateMovement(playerPlaying);
                playerPlaying++;// moves to the next player number
            }
            else
            {
                playerPlaying = 0; //moves to the first player again after all the players had turn
                HareAndTortoiseGame.EachPlayOneRound(playerPlaying);
                AnimateMovement(playerPlaying);
                playerPlaying++;
            }

            SetupPlayersDataGridView();
            btnSingleStep.Enabled = true;
            comboBox1.Enabled = true;
            resetButton.Enabled = true;
            if (HareAndTortoiseGame.Players[playerPlaying].Location.Number == Board.FINISH_SQUARE_NUMBER) {
                btnSingleStep.Enabled = false; //disables the button after the game has finished
            }//end if

        }

        /*** END OF EVENT-HANDLING METHODS ***/
    }
}

