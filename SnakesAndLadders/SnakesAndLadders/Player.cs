using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Player
    {
        public string Name { get; }
        public int Position { get; set; }

        public Player(string name)
        {
            Name = name;
            Position = 0;
        }

        public void Move(int steps, Dictionary<int, int> snakes, Dictionary<int, int> ladders)
        {
            Position += steps;

            
            if (snakes.ContainsKey(Position))
                Position = snakes[Position];

           
            if (ladders.ContainsKey(Position))
                Position = ladders[Position];

            
            if (Position > 100)
                Position = 100;
        }

        public bool HasWon() => Position == 100;

    }
}
