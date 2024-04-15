namespace GuessTheNumber;

class Game
{
    public static int RandomNumber() 

    {
        Random numRam= new Random();

        return numRam.Next(1,101);
    }
}



