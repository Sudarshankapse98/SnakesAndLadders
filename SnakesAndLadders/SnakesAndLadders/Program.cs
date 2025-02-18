using SnakesAndLadders;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Player 1 Dice Rolls:");
        string rolls1 = Console.ReadLine();

        Console.WriteLine("Enter Player 2 Dice Rolls:");
        string rolls2 = Console.ReadLine();

        Game game = new Game();
        game.Play(rolls1, rolls2);
    }
}
