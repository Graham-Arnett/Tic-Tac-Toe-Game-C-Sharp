namespace Tic_Tac_Toe_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my tic tac toe game!");
            string choice;
            //we would probably start the core loop around here
            do 
            {
                
                Console.Write("Wouold you like to play again?");
                choice = Console.ReadLine().ToLower();
            }while(choice =="y");
            //prompt user for where they want to place their mark, user is X, user will always go first
            //have the computer pick a spot, for the sake of simplicity make this version just pick a spot from a random number

            //we want the grid printed out and to update with new inputs, not just print again for each new input
            //3 in a row win, if no 3 in a row is possible the game is a draw

            Console.WriteLine("Goodbye, thanks for playing!"); //what displays when the user ends the game
        }
    }
}
