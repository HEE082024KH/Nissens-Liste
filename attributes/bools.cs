namespace SantasListGenerator.Attributes
{
  public class Bools
  {

    public bool toiletPaperOutward;
    public bool donatesToCharity;
    public bool washesHands;
    public int naughtyOrNice {get; set;} = 0;

    public void resetScore()
    {
      naughtyOrNice = 0;
    }

    public void ToiletPaper()
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

    public void Charity()
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

    public void WashesHands()
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