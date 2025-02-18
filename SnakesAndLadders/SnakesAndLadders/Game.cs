using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Game
    {

        private readonly Dictionary<int, int> _snakes;
        private readonly Dictionary<int, int> _ladders;
        private readonly Player _player1;
        private readonly Player _player2;

        public Game()
        {
            _snakes = new Dictionary<int, int>
        {
            { 32, 10 }, { 34, 6 }, { 48, 26 }, { 62, 18 }, { 88, 24 }, { 95, 56 }, { 97, 78 }
        };

            _ladders = new Dictionary<int, int>
        {
            { 1, 38 }, { 4, 14 }, { 8, 30 }, { 21, 42 }, { 28, 76 }, { 50, 67 }, { 71, 92 }, { 88, 99 }
        };

            _player1 = new Player("Player 1");
            _player2 = new Player("Player 2");
        }

        public void Play(string rolls1, string rolls2)
        {
            for (int i = 0; i < Math.Max(rolls1.Length, rolls2.Length); i++)
            {
                if (i < rolls1.Length)
                {
                    int diceRoll = int.Parse(rolls1[i].ToString());
                    _player1.Move(diceRoll, _snakes, _ladders);
                    Console.WriteLine($"{_player1.Name} is at position {_player1.Position}");

                    if (_player1.HasWon())
                    {
                        Console.WriteLine($"{_player1.Name} wins!");
                        return;
                    }
                }

                if (i < rolls2.Length)
                {
                    int diceRoll = int.Parse(rolls2[i].ToString());
                    _player2.Move(diceRoll, _snakes, _ladders);
                    Console.WriteLine($"{_player2.Name} is at position {_player2.Position}");

                    if (_player2.HasWon())
                    {
                        Console.WriteLine($"{_player2.Name} wins!");
                        return;
                    }
                }
            }
        }
    }
}
