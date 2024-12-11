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

public static class SantasListManager
{
    public static void EvaluateAndAssign(List<Person> people)
    {
        // Evaluate users and sort into good and bad lists
        var goodList = new List<Person>();
        var badList = new List<Person>();

        foreach (var person in people)
        {
            int totalScore = Bools.CalculateNaughtyOrNice(person); // Assuming static method in Bools
            if (totalScore >= 0)
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
            Console.WriteLine($"{person.name} is assigned to {elf.Name}, who gives a {gift}.");
        }

        Console.WriteLine("\nBad List:");
        var random = new Random();
        foreach (var user in badList)
        {
            if (random.Next(0, 10) == 0)
            {
                Console.WriteLine($"{user.name} is visited by Gryla and eaten!");
            }
            else
            {
                Console.WriteLine($"{user.name} receives coal.");
            }
        }
    }
}