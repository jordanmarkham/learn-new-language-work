namespace Game.Tests
{
  public class Game
  {
    string word;
    int attempts = 10;
    public Game()
    {
      WordChoser wordchoser = new WordChoser();
      this.word = wordchoser.GetRandomWordFromDictionary();
    }
    public string GetWordToGuess()
    {
      System.Text.StringBuilder builder = new System.Text.StringBuilder();
      for (int i = 0; i < this.word.Length; i++)
      {
        char letter = this.word[0];
        if (i == 0) {
          builder.Append(letter);
        }
        else {
          builder.Append("_");
        }
      }
      return builder.ToString();
    }

    public int GetRemainingAttempts()
    {
      return attempts;
    }
  }
}