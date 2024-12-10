﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using SantasListGenerator.Attributes;

namespace SantasListGenerator;

class Program
{
    static void Main(string[] args)
    {
        // Generate random users
        var randomizer = new Randomiser();
        UserInfo[] randomUsers = new UserInfo[100];
        for (int i = 0; i < randomUsers.Length; i++)
        {
            randomUsers[i] = new UserInfo()
            {
                Id = Guid.NewGuid(),
                Name = randomizer.GetRandomName(),
                ToiletPaperOutward = randomizer.CoinFlip(),
                DonatesToCharity = randomizer.CoinFlip(),
                WashesHands = randomizer.CoinFlip(),
                MusicGenres = randomizer.GetRandomMusicGenres(),
                HomeAdress = randomizer.GetRandomStreetName(),
                CarModel = randomizer.GetRandomCarModel()
            };
        }

        // Serialize users to JSON
        JsonSerializerOptions options = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        File.WriteAllText("randomPeople.json", JsonSerializer.Serialize(randomUsers, options));

        // Deserialize users
        var users = JsonSerializer.Deserialize<UserInfo[]>(
            File.ReadAllText("randomPeople.json"), options);

        // Define evaluation criteria
        var goodMusicGenres = new HashSet<string> { "Classical", "Jazz", "Blues", "Folk", "Soul" };
        var badMusicGenres = new HashSet<string> { "Metal", "Punk", "Industrial", "Grunge", "Hardcore" };
        var goodCarModel = new HashSet<string> { "Ford Fiesta", "Toyota Corolla", "BMW 5 Series" };
        var badCarModel = new HashSet<string> { "Chrysler 300", "Ford Mustang", "Chevrolet Camaro" };
        var goodStreet = new HashSet<string> { "Arne Garborgs gate", "Asbjørnsens gate", "Kalfarveien" };
        var badStreet = new HashSet<string> { "Fortunen", "Cort Piil-Smauet", "Arbeidergaten" };

        // Define weighting for traits
        var traitWeights = new Dictionary<string, Func<UserInfo, int>>
        {
            { "ToiletPaperOutward", user => user.ToiletPaperOutward ? 1 : -1 },
            { "DonatesToCharity", user => user.DonatesToCharity ? 2 : -2 },
            { "WashesHands", user => user.WashesHands ? 1 : -1 },
            { "MusicGenres", user => user.MusicGenres.Count(genre => goodMusicGenres.Contains(genre)) -
            user.MusicGenres.Count(genre => badMusicGenres.Contains(genre)) },
            { "CarModel", user => (goodCarModel.Contains(user.CarModel) ? 1 : 0) -
            (badCarModel.Contains(user.CarModel) ? 1 : 0) },
            { "HomeAdress", user => (goodStreet.Contains(GetStreetName(user.HomeAdress)) ? 1 : 0) -
            (badStreet.Contains(GetStreetName(user.HomeAdress)) ? 1 : 0) }
        };


        // Evaluate users and sort into good and bad lists
        var goodList = new List<UserInfo>();
        var badList = new List<UserInfo>();

        foreach (var user in users)
        {
            int totalScore = traitWeights.Sum(trait => trait.Value(user));

            if (totalScore > 0)
                goodList.Add(user);
            else
                badList.Add(user);
        }

        // Assign elves and gifts to the good list
        var elves = new List<Elf>
        {
            new Elf("Alvhild", "woodworking"),
            new Elf("Erik", "electronics"),
            new Elf("Freya", "sewing"),
            new Elf("Bjorn", "blacksmithing"),
            new Elf("Ingrid", "ceramics")
        };

        var gifts = new Dictionary<string, string>
        {
            { "woodworking", "cutting board" },
            { "electronics", "smartwatch" },
            { "sewing", "scarf" },
            { "blacksmithing", "sword" },
            { "ceramics", "vase" }
        };

        Console.WriteLine("Good List:");
        for (int i = 0; i < goodList.Count; i++)
        {
            var person = goodList[i];
            var elf = elves[i % elves.Count];
            var gift = gifts[elf.Specialty];
            Console.WriteLine($"{person.Name} is assigned to {elf.Name}, who gives a {gift}.");
            Console.WriteLine($"Address: {person.HomeAdress}");
            Console.WriteLine($"Car: {person.CarModel}");
            Console.WriteLine($"Favorite Music: {string.Join(", ", person.MusicGenres)}\n");
        }

        // Handle the bad list
        Console.WriteLine("\nBad List:");
        var random = new Random();
        foreach (var user in badList)
        {
            if (random.Next(1, 11) == 1) // 10% chance
                Console.WriteLine($"{user.Name} is visited by Gryla and eaten!");
            else
                Console.WriteLine($"{user.Name} receives coal.");
        }
    }

    private static string GetStreetName(string homeAdress)
    {
        throw new NotImplementedException();
    }

    public class UserInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool ToiletPaperOutward { get; set; }
        public bool DonatesToCharity { get; set; }
        public bool WashesHands { get; set; }
        public string[] MusicGenres { get; set; }
        public string HomeAdress { get; set; }
        public string CarModel { get; set; }
    }

    public class Randomiser 
    {
        private readonly string[] Names = {"Liam", "Noah", "Oliver", "Elijah", "William",
        "James", "Benjamin", "Lucas", "Henry", "Alexander",
        "Mason", "Michael", "Ethan", "Daniel", "Jacob",
        "Logan", "Jackson", "Levi", "Sebastian", "Mateo",
        "Jack", "Owen", "Theodore", "Aiden", "Samuel",
        "Joseph", "John", "David", "Wyatt", "Matthew",
        "Luke", "Asher", "Carter", "Julian", "Grayson",
        "Leo", "Jayden", "Gabriel", "Isaac", "Lincoln",
        "Anthony", "Hudson", "Dylan", "Ezra", "Thomas",
        "Charles", "Christopher", "Jaxon", "Maverick", "Josiah",
        "Olivia", "Emma", "Charlotte", "Amelia", "Sophia",
        "Isabella", "Ava", "Mia", "Evelyn", "Luna",
        "Harper", "Camila", "Gianna", "Elizabeth", "Eleanor",
        "Ella", "Abigail", "Sofia", "Avery", "Scarlett",
        "Emily", "Aria", "Penelope", "Chloe", "Layla",
        "Mila", "Nora", "Hazel", "Madison", "Ellie",
        "Lily", "Nova", "Isla", "Grace", "Violet",
        "Aurora", "Riley", "Zoey", "Willow", "Emilia",
        "Stella", "Zoe", "Victoria", "Hannah", "Addison",
        "Leah", "Lucy", "Eliana", "Ivy", "Everly"
        };
        private readonly string[] CarModels = {"Ford Fiesta", "Volkswagen Golf", "Toyota Corolla", "Honda Civic", "Chevrolet Cruze",
        "BMW 3 Series", "Audi A4", "Mercedes-Benz C-Class", "Hyundai Elantra", "Nissan Altima",
        "Kia Optima", "Mazda3", "Subaru Impreza", "Volkswagen Passat", "Toyota Camry",
        "Honda Accord", "Chevrolet Malibu", "Ford Fusion", "Nissan Maxima", "Hyundai Sonata",
        "Kia Stinger", "BMW 5 Series", "Audi A6", "Mercedes-Benz E-Class", "Lexus ES",
        "Jaguar XF", "Volvo S60", "Alfa Romeo Giulia", "Tesla Model 3", "Porsche Panamera",
        "Chevrolet Impala", "Chrysler 300", "Dodge Charger", "Ford Mustang", "Chevrolet Camaro",
        "Dodge Challenger", "Toyota Supra", "Nissan 370Z", "BMW Z4", "Audi TT",
        "Mercedes-Benz SLK", "Mazda MX-5 Miata", "Subaru BRZ", "Hyundai Veloster", "Kia Forte",
        "Volkswagen Jetta", "Honda Fit", "Toyota Yaris", "Ford Focus", "Chevrolet Spark"};
        private readonly string[] MusicGenres = { "Pop", "Rock", "Hip Hop", "Jazz", "Classical",
        "Electronic", "Country", "R&B", "Reggae", "Blues",
        "Metal", "Soul", "Funk", "Disco", "Punk",
        "Folk", "Gospel", "Latin", "Ska", "House",
        "Techno", "Trance", "Dubstep", "Ambient", "Indie",
        "Grunge", "K-Pop", "J-Pop", "Opera", "Swing",
        "Bluegrass", "Afrobeat", "Salsa", "Merengue", "Bossa Nova",
        "Flamenco", "Reggaeton", "Zouk", "Calypso", "Dancehall",
        "Electro", "Synthpop", "New Wave", "Post-Punk", "Shoegaze",
        "Emo", "Hardcore", "Industrial", "Trip-Hop", "World Music"};
        private readonly string[] StreetNames = {"Aad Gjelles gate", "Abels gate", "Absalon Beyers gate", "Adolph Bergs vei", "Agnes Mowinckels gate",
        "Allégaten", "Allehelgens gate", "Amalie Skrams vei", "Arbeidergaten", "Armauer Hansens vei",
        "Arne Garborgs gate", "Arnoldus Reimers' gate", "Asbjørnsens gate", "Astrups vei", "Asylplassen",
        "Baglergaten", "Baneveien", "Bankgaten", "Bispengsgaten", "Bjerregårds gate",
        "Bjørnsons gate", "Blaauws vei", "Bontelabo", "Bradbenken", "Bredalsmarken",
        "Bredsgården", "Breistølen", "Breiviksveien", "Bryggen", "Bøhmergaten",
        "C. Sundts gate", "Christian Michelsens gate", "Christies gate", "Cort Piil-Smauet", "Damsgårdsveien",
        "Dreggsallmenningen", "Engen", "Fabrikkgaten", "Finnegårdsgaten", "Fjøsangerveien",
        "Fortunen", "Hans Hauges gate", "Haugeveien", "Hollendergaten", "Jonas Lies vei",
        "Kaigaten", "Kalfarveien", "Kirkegaten", "Klosteret", "Kong Oscars gate"};
         private readonly int[] StreetNumbers = Enumerable.Range(1, 200).ToArray();
         private readonly Random _random = new();

        public string GetRandomName() => Names[_random.Next(Names.Length)];
        public string GetRandomStreetName() => $"{StreetNames[_random.Next(StreetNames.Length)]} {StreetNumbers[_random.Next(StreetNumbers.Length)]}";
        public bool CoinFlip() => _random.Next(2) == 1;
        public string[] GetRandomMusicGenres() => MusicGenres.OrderBy(_ => Guid.NewGuid()).Take(3).ToArray();
        public string GetRandomCarModel() => CarModels[_random.Next(CarModels.Length)];
    }

    public class Elf
    {
        public string Name { get; }
        public string Specialty { get; }

        public Elf(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
        }
    }
}