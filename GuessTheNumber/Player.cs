using System;

namespace GuessTheNumber
{
    class Player 
    {
        // Propiedades
        private string _playerName;
        private int _lastAttempt;

        // Constructor
        public Player(string playerName)
        {
            _playerName = playerName;
            _lastAttempt = 0;
        }

        public void MakeGuess()
        {
            Console.WriteLine($"{_playerName}, ingresa tu opción:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int guess))
            {
                _lastAttempt = guess;
            }
            else 
            {
                Console.WriteLine("Ooh, you must enter a valid number");
            }
        }

        public int GetLastAttempt()
        {
            return _lastAttempt;
        }

        public string GetPlayerName()
        {
            return _playerName;
        }

    }
}
