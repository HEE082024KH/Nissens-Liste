using SantasListGenerator.Attributes;

namespace SantasListGenerator;
public enum ElfSpecialty
{
    WoodWorking,
    Electronics,
    Sewing,
    Blacksmithing,
    Ceramics
}

public class Elf
{
    public readonly string Name;
    public readonly ElfSpecialty Specialty;

    public Elf(string name, ElfSpecialty specialty)
    {
        Name = name;
        Specialty = specialty;
    }
}

public class SantasListManager
{
    Bools bools = new();
    public void EvaluateAndAssign(List<Person> people)
    {
        // Evaluate users and sort into good and bad lists
        var goodList = people.Where(p => p.naughtyOrNiceScore >= 15).ToList(); //p = person in people list. 15 or higher = GOOD LIST
        var badList = people.Where(p => p.naughtyOrNiceScore < 15).ToList(); //if score less than 15. BAD LIST

        foreach (var person in people)
        {
            int totalScore = person.naughtyOrNiceScore; // Assuming static method in Bools
            Console.WriteLine($"Evaluating {person.name} with score: {person.naughtyOrNiceScore}");

            if (person.naughtyOrNiceScore >= 0)
            {
                goodList.Add(person);
            }
            else
            {
                badList.Add(person);
            }
        }

        // Assign elves and gifts to the good list
        var elves = new List<Elf>
        {
            new ("Alvhild", ElfSpecialty.WoodWorking),
            new ("Erik", ElfSpecialty.Electronics),
            new ("Freya", ElfSpecialty.Sewing),
            new ("Bjorn", ElfSpecialty.Blacksmithing),
            new ("Ingrid", ElfSpecialty.Ceramics)
        };

        var gifts = new Dictionary<ElfSpecialty, string>
        {
            { ElfSpecialty.WoodWorking, "carved animal figurine" },
            { ElfSpecialty.Electronics, "headset" },
            { ElfSpecialty.Sewing, "kitchen towels" },
            { ElfSpecialty.Blacksmithing, "pocket knife" },
            { ElfSpecialty.Ceramics, "ceramic mug" }
        };

        Console.WriteLine("\nGood List:");
        for (int i = 0; i < goodList.Count; i++)
        {
            var person = goodList[i];
            var elf = elves[i % elves.Count];
            var gift = gifts[elf.Specialty];
            Console.WriteLine($"{person.name} is assigned to {elf.Name}, who gives a {gift}.{person.naughtyOrNiceScore}");
        }

        Console.WriteLine("\nBad List:");
        var random = new Random();
        foreach (var person in badList)
        {
            if (random.Next(0, 10) == 0)
            {
                Console.WriteLine($"{person.name} is visited by Gryla and eaten!{person.naughtyOrNiceScore}");
            }
            else
            {
                Console.WriteLine($"{person.name} receives coal. {person.naughtyOrNiceScore}");
            }
        }
    }
}