namespace GuessTheNumber;

class Game
{
    public static void Main (string[] args) 

    {
         Random r= new Random ();

        Console.WriteLine(r.Next (1,101));

        Console.ReadLine ();
    }
}



// Generar un número aleatorio entre 1 y 100.
// Implementar un bucle que solicite a la jugadora que adivine el número.
// Proporcionar pista si es mayor o menor

