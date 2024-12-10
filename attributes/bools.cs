public class Bools
{
  public bool toiletPaperOutward;
  public bool donatesToCharity;
  public bool washesHands;
  public int naughtyOrNice;

  switch (toiletPaperOutward)
  {
    case true:
      naughtyOrNice = +10;
      break;
    case false:
      naughtyOrNice = -10;
      break;
  }

  switch (donatesToCharity)
  {
    case true:
      naughtyOrNice = +20
      break;
    case false:
    break;
  }

  switch (washesHands)
  {
    case true:
      break;
    case false:
      naughtyOrNice = -20
      break;
  }
}