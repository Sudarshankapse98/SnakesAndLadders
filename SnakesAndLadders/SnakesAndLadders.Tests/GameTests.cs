using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace SnakesAndLadders.Tests
{
    public class GameTests
    {
        [Fact]
        public void TestPlayerMovesCorrectly()
        {
            Player player = new Player("TestPlayer");
            var snakes = new Dictionary<int, int> { { 16, 6 } };
            var ladders = new Dictionary<int, int> { { 2, 38 } };

            player.Move(2, snakes, ladders); // Should go to 38
            Assert.Equal(38, player.Position);

            player.Move(16, snakes, ladders); // Should go down to 6
            Assert.Equal(6, player.Position);
        }

        [Fact]
        public void TestWinningCondition()
        {
            Player player = new Player("TestPlayer");
            for (int i = 0; i < 10; i++) player.Move(10, new Dictionary<int, int>(), new Dictionary<int, int>());
            Assert.True(player.HasWon());
        }
    }
}
