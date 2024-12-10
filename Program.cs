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
        Bools bools = new();

        // Step 1: Load JSON from a file
        string jsonFilePath = "randomPeople.json";
        string jsonString = File.ReadAllText(jsonFilePath);

        // Step 2: Deserialize JSON into an object
        List<Person>? people = JsonSerializer.Deserialize<List<Person>>(jsonString);

        // Step 3: Initialize a variable to hold the "naughty or nice" score
        bools.naughtyOrNice = 0;
        Console.WriteLine(people); //test to see if it writes out the attributes
        if (people != null)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.name}, Address: {person.homeAdress}");
            }
        }
    }
}