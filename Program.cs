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
        HomeAdress homeAdress = new();
        MusicGenre musicGenre = new();
        CarModels carModels = new();
        Bools bools = new();


        // Step 1: Load JSON from a file
        string jsonFilePath = "randomPeople.json";
        string jsonString = File.ReadAllText(jsonFilePath);

        // Step 2: Deserialize JSON into an object
        List<Person>? people = JsonSerializer.Deserialize<List<Person>>(jsonString);

        // Step 3: Initialize a variable to hold the "naughty or nice" score
        bools.naughtyOrNice = 0;


        //test to see if it writes out the attributes
        // if (people != null)
        // {
        //     foreach (var person in people)
        //     {
        //         Console.WriteLine($"- Name: {person.name}, Address: {person.homeAdress}, Washes Hands: {person.washesHands}, Toilet Paper Out or In: {person.toiletPaperOutward}, Donates to charity: {person.donatesToCharity},\n Car Model: {person.carModel}, Music Genres: {string.Join(", ", person.musicGenres)} ");
        //     }
        // }

        if (people != null)
        {
            foreach (var person in people) //loops over each Person in people list
            {
                bools.resetScore();//making sure the score starts at 0 for each person

                homeAdress.godBadAdress(person.homeAdress);
                bools.WashesHands();
                bools.ToiletPaper();
                bools.Charity();
                carModels.Cars(person.carModel ?? ""); //checks carmodel of person, if null it uses empty string
                if (person.musicGenres != null)
                {
                    foreach (var genre in person.musicGenres) //goes through each genre
                    {
                        musicGenre.EvaluateGenre(genre);
                    }
                }

                bools.toiletPaperOutward = person.toiletPaperOutward ?? false; //if toiletpaperotward is null = false
                bools.donatesToCharity = person.donatesToCharity ?? false;
                bools.washesHands = person.washesHands ?? false;

                person.naughtyOrNiceScore = bools.naughtyOrNice;

                Console.WriteLine($"Name: {person.name}, Address: {person.washesHands}, Score: {person.naughtyOrNiceScore}");
            }
        }
        var manager = new SantasListManager();
        manager.EvaluateAndAssign(people);
    }
}