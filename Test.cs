// Previous code, saved here incase needed for later

// // Define evaluation criteria
// var goodMusicGenres = new HashSet<string> { "Classical", "Jazz", "Blues", "Folk", "Soul" };
// var badMusicGenres = new HashSet<string> { "Metal", "Punk", "Industrial", "Grunge", "Hardcore" };
// var goodCarModel = new HashSet<string> { "Ford Fiesta", "Toyota Corolla", "BMW 5 Series" };
// var badCarModel = new HashSet<string> { "Chrysler 300", "Ford Mustang", "Chevrolet Camaro" };
// var goodStreet = new HashSet<string> { "Arne Garborgs gate", "Asbjørnsens gate", "Kalfarveien" };
// var badStreet = new HashSet<string> { "Fortunen", "Cort Piil-Smauet", "Arbeidergaten" };

// // Define weighting for traits
// var traitWeights = new Dictionary<string, Func<UserInfo, int>>
//         {
//             { "ToiletPaperOutward", user => user.ToiletPaperOutward ? 1 : -1 },
//             { "DonatesToCharity", user => user.DonatesToCharity ? 2 : -2 },
//             { "WashesHands", user => user.WashesHands ? 1 : -1 },
//             { "MusicGenres", user => user.MusicGenres.Count(genre => goodMusicGenres.Contains(genre)) -
//             user.MusicGenres.Count(genre => badMusicGenres.Contains(genre)) },
//             { "CarModel", user => (goodCarModel.Contains(user.CarModel) ? 1 : 0) -
//             (badCarModel.Contains(user.CarModel) ? 1 : 0) },
//             { "HomeAdress", user => (goodStreet.Contains(GetStreetName(user.HomeAdress)) ? 1 : 0) -
//             (badStreet.Contains(GetStreetName(user.HomeAdress)) ? 1 : 0) }
//         };


// // Evaluate users and sort into good and bad lists
// var goodList = new List<UserInfo>();
// var badList = new List<UserInfo>();

// foreach (var user in users)
// {
//   int totalScore = traitWeights.Sum(trait => trait.Value(user));

//   if (totalScore > 0)
//     goodList.Add(user);
//   else
//     badList.Add(user);
// }

// // Assign elves and gifts to the good list
// var elves = new List<Elf>
//         {
//             new Elf("Alvhild", "woodworking"),
//             new Elf("Erik", "electronics"),
//             new Elf("Freya", "sewing"),
//             new Elf("Bjorn", "blacksmithing"),
//             new Elf("Ingrid", "ceramics")
//         };

// var gifts = new Dictionary<string, string>
//         {
//             { "woodworking", "cutting board" },
//             { "electronics", "smartwatch" },
//             { "sewing", "scarf" },
//             { "blacksmithing", "sword" },
//             { "ceramics", "vase" }
//         };

// Console.WriteLine("Good List:");
// for (int i = 0; i < goodList.Count; i++)
// {
//   var person = goodList[i];
//   var elf = elves[i % elves.Count];
//   var gift = gifts[elf.Specialty];
//   Console.WriteLine($"{person.Name} is assigned to {elf.Name}, who gives a {gift}.");
//   Console.WriteLine($"Address: {person.HomeAdress}");
//   Console.WriteLine($"Car: {person.CarModel}");
//   Console.WriteLine($"Favorite Music: {string.Join(", ", person.MusicGenres)}\n");
// }

// // Handle the bad list
// Console.WriteLine("\nBad List:");
// var random = new Random();
// foreach (var user in badList)
// {
//   if (random.Next(1, 11) == 1) // 10% chance
//     Console.WriteLine($"{user.Name} is visited by Gryla and eaten!");
//   else
//     Console.WriteLine($"{user.Name} receives coal.");
// }
//     }

//     public class Elf
// {
//   public string Name { get; }
//   public string Specialty { get; }

//   public Elf(string name, string specialty)
//   {
//     Name = name;
//     Specialty = specialty;
//   }
// }