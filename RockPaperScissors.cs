public class RockPaperScissors
{
    const string Rock = "Rock";
    const string Paper = "Paper";
    const string Scissors = "Scissors";
     
    public static void Main()
    {
        Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors");

        string playerMove = GetPlayerMove();
        string computerMove = GetComputerMove();
        string winner = GetTheWinner(playerMove, computerMove);
        Console.WriteLine(winner);
    }

    static string GetTheWinner(string playerMove, string computerMove)
    {
        string winner = string.Empty;

        if (playerMove == Rock && computerMove == Scissors ||
            playerMove == Paper && computerMove == Rock ||
            playerMove == Scissors && computerMove == Paper)
        {
            winner = "You win.";
        }
        else if (computerMove == Rock && playerMove == Scissors ||
            computerMove == Paper && playerMove == Rock ||
            computerMove == Scissors && playerMove == Paper)
        {
            winner = "You lose.";
        }
        else if (playerMove == computerMove)
        {
            winner = "This game was a draw";
        }

        return winner;
    }
    static string GetComputerMove()
    {
        Random random = new Random();
        int n = random.Next(1, 4);
        string computerMove = string.Empty;

        if (n == 1)
        {
            computerMove = Rock;
        }
        else if (n == 2)
        {
            computerMove = Paper;
        }
        else if (n == 3)
        {
            computerMove = Scissors;
        }

        Console.WriteLine($"The opponent chose {computerMove}.");
        return computerMove;
    }
    static string GetPlayerMove()
    {
        string playerMove = Console.ReadLine();

        if (playerMove == "r" || playerMove == "rock")
        {
            playerMove = Rock;
        }
        else if (playerMove == "p" || playerMove == "paper")
        {
            playerMove = Paper;
        }
        else if(playerMove == "s" || playerMove == "scissors")
        {
            playerMove = Scissors;
        }
        else
        {
            Console.WriteLine("Invalid Input. Try Again!");
            Environment.Exit(0);
        }

        return playerMove;
    }
}
