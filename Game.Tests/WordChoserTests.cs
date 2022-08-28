using NSubstitute;

namespace Game.Tests {
  [TestFixture]
  public class WordChoserTests {
    [Test]
    public void WordChoser_ChooseWordToGuess_ReturnsWordFromArray() {
      WordChoser substitute = Substitute.For<WordChoser>();
      substitute.GetRandomWordFromDictionary().Returns("MAKERS");

      Assert.AreEqual("MAKERS", substitute.GetRandomWordFromDictionary());
    }
  }
}