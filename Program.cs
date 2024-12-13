﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SantasListGenerator.Attributes;

namespace SantasListGenerator;

class Program
{
    static void Main(string[] args)
    {
        HomeAdress homeAdress = new();
        MusicGenre musicGenre = new();
        CarModels carModels = new();
        Bools bools = new();

        // Step 1: Load JSON from a file
        string jsonFilePath = "randomPeople.json";
        string jsonString = File.ReadAllText(jsonFilePath);

        // Step 2: Deserialize JSON into an object
        List<Person>? people = JsonSerializer.Deserialize<List<Person>>(jsonString);

        // Ensure people list is not null
        if (people != null)
        {
            // Process each person
            foreach (var person in people)
            {
                // Debug: Print person's carModel and check if it's missing or null
                Console.WriteLine($"Evaluating person: {person.name}, Car model: {person.carModel}");

                // Check if carModel is missing or null
                if (string.IsNullOrEmpty(person.carModel))
                {
                    Console.WriteLine($"Car model is missing or empty for {person.name}. Skipping evaluation.");
                    continue;  // Skip this iteration if carModel is missing
                }

                // Reset score for each person
                bools.resetScore();

                // Apply the evaluation of attributes
                bools.toiletPaperOutward = person.toiletPaperOutward ?? false;
                bools.donatesToCharity = person.donatesToCharity ?? false;
                bools.washesHands = person.washesHands ?? false;

                bools.WashesHands();
                bools.ToiletPaper();
                bools.Charity();

                // Evaluate home address
                if (person.homeAdress != null)
                {
                    homeAdress.godBadAdress(person.homeAdress);
                }

                // Evaluate car model
                carModels.Cars();  // This will process carModel for each person

                // Evaluate music genres
                if (person.musicGenres != null)
                {
                    foreach (var genre in person.musicGenres)
                    {
                        musicGenre.EvaluateGenre(genre);
                    }
                }

                // Set the final naughtyOrNiceScore for the person
                person.naughtyOrNiceScore = bools.naughtyOrNice;

                // Output the final score for debugging
                Console.WriteLine($"Final naughtyOrNice score for {person.name}: {person.naughtyOrNiceScore}");
            }

            // Now process and assign elves (if any)
            var manager = new SantasListManager();
            manager.EvaluateAndAssign(people);
        }
        else
        {
            Console.WriteLine("No people found in JSON file.");
        }
    }
}