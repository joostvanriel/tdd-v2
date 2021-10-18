using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Bowling_Game.Tests
{
    [TestClass]
    public class GameTest
    {
        private Game game;

        [TestInitialize]
        public void SetUp()
        {
            game = new Game();
        }

        [TestMethod]
        public void AGutterGameShouldResultIn0()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void AllOnesShouldResultIn20()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void ASpareShouldCountNextRollDouble()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, game.Score());
        }

        [TestMethod]
        public void AStrikeShouldCountNextTwoRollsDouble()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, game.Score());
        }

        [TestMethod]
        public void APerfectGameShouldResultIn300()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, game.Score());
        }

        private void RollMany(int nrOfRolls, int scorePerRoll)
        {
            for (var i = 0; i < nrOfRolls; i++)
            {
                game.Roll(scorePerRoll);
            }
        }
    }
}
