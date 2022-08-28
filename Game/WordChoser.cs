namespace Game.Tests
{
  public class WordChoser
  {
    readonly string[] DICTIONARY = {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};
    public virtual string GetRandomWordFromDictionary()
    {
      Random rand = new Random();
      int index = rand.Next(DICTIONARY.Length);
      return DICTIONARY[index];
    }
  }
}