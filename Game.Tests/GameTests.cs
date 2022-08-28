using NSubstitute;

namespace Game.Tests {
  [TestFixture]
  public class GameTests {
    [Test]
    public void Game_GetWordToGuess_ReturnsWordToGuess() {
      WordChoser substitute = Substitute.For<WordChoser>();
      substitute.GetRandomWordFromDictionary().Returns("MAKERS");

      Game game = new Game();
      Assert.AreEqual("M_____", game.GetWordToGuess());
    }
    [Test]
    public void Game_GetRemainingAttempts_ReturnsNumberOfAttemptsLeft() {
      Game game = new Game();
      Assert.AreEqual(10, game.GetRemainingAttempts());
    }
  }
}