using Xunit;

namespace Practice.Tests
{
    
    public class BowlingGameTests
    {
        private BowlingGame game;

        public BowlingGameTests()
        {
            game = new BowlingGame();
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.Roll(pins);
            }
        }


        [Fact]
        public void GutterGame()
        {
            RollMany(20, 0);
            Assert.Equal(0, game.Score());
        }

        [Fact]
        public void KnockedDownOnePinEachFrame()
        {
            RollMany(20, 1);
            Assert.Equal(20, game.Score());
        }

        //[Fact]
        //public void OneSpare()
        //{
        //    game.Roll(5);
        //    game.Roll(5);
        //    game.Roll(3);
        //    RollMany(17, 0);
        //    Assert.Equal(16, game.Score());
        //}
    }
}
