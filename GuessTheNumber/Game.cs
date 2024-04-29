using System;

namespace GuessTheNumber
{

    class Game
    {
       private int randomNumber;
       private Player player;

       public Game(string playerName)
       {
            Random numRam= new Random();
            randomNumber = numRam.Next(1, 101);

            player = new Player(playerName); // Crea una nueva instancia de Player
       }

       public void StartNewGame()
       {
        Console.WriteLine($"You're playing against {player.GetPlayerName()}.");
        Console.WriteLine("You have two attemps ");

        for (int i = 1; i <= 2; i++)
        {
            player.MakeGuess();

            if (player.GetLastAttempt() == randomNumber)
            {
                Console.WriteLine("Congratulations, you won");
                return;
            }
            else if (i < 2)
            {
                Console.WriteLine("Keep trying...");
            }
        }
            Console.WriteLine($"You lost, the number was {randomNumber}");
       }
     
    }
}
