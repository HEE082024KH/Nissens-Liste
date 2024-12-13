namespace SantasListGenerator.Attributes
{
  public class CarModels2
  {
    Bools bools = new();
    public void Cars2(string models)
    {
      if
      (
        models.Contains("Volkswagen Jetta") ||
        models.Contains("Chevrolet Spark") ||
        models.Contains("Ford Fiesta") ||
        models.Contains("Chevrolet Malibu") ||
        models.Contains("Subaru Impreza") ||
        models.Contains("Mazda MX-5 Miata") ||
        models.Contains("Audi A6") ||
        models.Contains("Ford Mustang") ||
        models.Contains("Honda Accord")
      )
      {
        bools.naughtyOrNice += 5;
      }
      else if
      (
        models.Contains("Kia Stinger") ||
        models.Contains("Kia Forte") ||
        models.Contains("Toyota Yaris") ||
        models.Contains("Kia Optima") ||
        models.Contains("Mercedes-Benz C-Class") ||
        models.Contains("BMW 5 Series") ||
        models.Contains("Mercedes-Benz SLK")
      )
      {
        bools.naughtyOrNice -= 5;
      }
      else if
      (
        models.Contains("Toyota Supra") ||
        models.Contains("Ford Focus") ||
        models.Contains("Subaru BRZ") ||
        models.Contains("Volkswagen Golf") ||
        models.Contains("Alfa Romeo Giulia") ||
        models.Contains("Nissan 370Z") ||
        models.Contains("Audi TT") ||
        models.Contains("Dodge Challenger")
      )
      {
        bools.naughtyOrNice += 10;
      }
      else if
      (
        models.Contains("Jaguar XF") ||
        models.Contains("Hyundai Veloster") ||
        models.Contains("Hyundai Sonata")
      )
      {
        bools.naughtyOrNice -= 10;
      }
      else if (models.Contains("Porsche Panamera"))
      {
        bools.naughtyOrNice -= 20;
      }
      else if (models.Contains("Dodge Charger"))
      {
        bools.naughtyOrNice += 15;
      }
      else if (models.Contains("Mercedes - Benz E - Class"))
      {
        bools.naughtyOrNice -= 15;
      }
      else if (models.Contains("Tesla Model 3"))
      {
        bools.naughtyOrNice -= 15;
      }
      else
      {
        return;
      }
    }
  }
}