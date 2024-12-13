namespace SantasListGenerator.Attributes
{
  public class CarModels
  {
    Bools bools = new();
    Person person = new();
    public void Cars()
    {
    //Console.WriteLine($"Evaluating car model: {person.carModel}");  // Debugging line
    //
    //// Check if car model is missing (this is optional now as you confirmed they are loaded correctly)
    //if (string.IsNullOrEmpty(person.carModel))
    //{
    //  Console.WriteLine($"Car model is missing or empty for {person.name}. Skipping evaluation.");
    //  return;  // Exit if car model is missing
    //}
      switch (person.carModel)
      {
        case "Volkswagen Jetta":
          bools.naughtyOrNice += 5;
          break;
        case "BMW Z4":
          break;
        case "Kia Stinger":
          bools.naughtyOrNice -= 5;
          break;
        case "Toyota Supra":
          bools.naughtyOrNice += 10;
          break;
        case "Kia Forte":
          bools.naughtyOrNice -= 5;
          break;
        case "Jaguar XF":
          bools.naughtyOrNice -= 10;
          break;
        case "Chevrolet Spark":
          bools.naughtyOrNice += 5;
          break;
        case "Toyota Yaris":
          bools.naughtyOrNice -= 5;
          break;
        case "Kia Optima":
          bools.naughtyOrNice -= 5;
          break;
        case "Ford Fiesta":
          bools.naughtyOrNice += 5;
          break;
        case "Ford Focus":
          bools.naughtyOrNice += 10;
          break;
        case "Chrysler 300":
          break;
        case "Porsche Panamera":
          bools.naughtyOrNice -= 20;
          break;
        case "Nissan Altima":
          break;
        case "Chevrolet Cruze":
          break;
        case "Mercedes - Benz E - Class":
          bools.naughtyOrNice -= 15;
          break;
        case "Subaru BRZ":
          bools.naughtyOrNice += 10;
          break;
        case "Chevrolet Malibu":
          bools.naughtyOrNice += 5;
          break;
        case "Volkswagen Golf":
          bools.naughtyOrNice += 10;
          break;
        case "Subaru Impreza":
          bools.naughtyOrNice += 5;
          break;
        case "Nissan Maxima":
          break;
        case "Hyundai Veloster":
          bools.naughtyOrNice -= 10;
          break;
        case "Alfa Romeo Giulia":
          bools.naughtyOrNice += 10;
          break;
        case "Mazda MX-5 Miata":
          bools.naughtyOrNice += 5;
          break;
        case "Toyota Camry":
          break;
        case "Nissan 370Z":
          bools.naughtyOrNice += 10;
          break;
        case "Honda Fit":
          break;
        case "Hyundai Sonata":
          bools.naughtyOrNice -= 10;
          break;
        case "Volvo S60":
          break;
        case "Dodge Charger":
          bools.naughtyOrNice += 15;
          break;
        case "Audi A6":
          bools.naughtyOrNice += 5;
          break;
        case "BMW 3 Series":
          break;
        case "Mercedes-Benz C-Class":
          bools.naughtyOrNice -= 5;
          break;
        case "Audi TT":
          bools.naughtyOrNice += 10;
          break;
        case "Ford Fusion":
          break;
        case "Tesla Model 3":
          bools.naughtyOrNice -= 15;
          break;
        case "BMW 5 Series":
          bools.naughtyOrNice -= 5;
          break;
        case "Dodge Challenger":
          bools.naughtyOrNice += 10;
          break;
        case "Toyota Corolla":
          break;
        case "Mercedes-Benz SLK":
          bools.naughtyOrNice -= 5;
          break;
        case "Ford Mustang":
          bools.naughtyOrNice += 5;
          break;
        case "Honda Accord":
          bools.naughtyOrNice += 5;
          break;
        //default:
        //  Console.WriteLine($"Unknown car model: {person.carModel}");
        //  break;
      }
      //Console.WriteLine($"Final naughtyOrNice score for {person.name}: {person.naughtyOrNiceScore}");
    }
  }
}