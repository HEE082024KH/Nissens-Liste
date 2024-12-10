namespace SantasListGenerator.Attributes
{
  public class Bools
  {

    public bool toiletPaperOutward;
    public bool donatesToCharity;
    public bool washesHands;
    public int naughtyOrNice;

    //switch must be inside a method, constructor, or property

    public ToiletPaper()
    {
      switch (toiletPaperOutward)
      {
        case true:
          naughtyOrNice += 10;
          break;
        case false:
          naughtyOrNice -= 10;
          break;
      }
    }

    public Charity()
    {
      switch (donatesToCharity)
      {
        case true:
          naughtyOrNice += 20;
          break;
        case false:
          break;
      }
    }

    public WashHands()
    {
      switch (washesHands)
      {
        case true:
          break;
        case false:
          naughtyOrNice += 20;
          break;
      }
    }
  }
}