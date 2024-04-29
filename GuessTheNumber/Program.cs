using System;

namespace GuessTheNumber
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string _playerName = Console.ReadLine();

            if (_playerName != null)
            {
                Game game = new Game(_playerName);
                game.StartNewGame();
            }
            else
            {
                Console.WriteLine("Invalid player name");
            }
        }
    }
}



//   int numRam = Game.RandomNumber();
//             Console.WriteLine("Es hora de adivinar. Tienes dos intentos.");
//             for (int i = 1; i < 3; i++) 
//             {
//                 Console.WriteLine($"{Environment.NewLine}Ingresa tu opción.");
//                 var attempt = Console.ReadLine();
//                 if (Int32.Parse(attempt) == numRam) 
//                 {
//                     Console.WriteLine("Ganaste, eres un coco");
//                     break;
//                 } else if (Int32.Parse(attempt) > numRam) 
//                 {
//                     Console.WriteLine("El número es menor");
//                 } else if (Int32.Parse(attempt) < numRam) 
//                 {
//                     Console.WriteLine("El número es mayor");
//                 }   
//             } 
