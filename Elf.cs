namespace SantasListGenerator;

public enum ElfSpecialty {
    WoodWorking,
    Electronics,
    Sewing,
    Blacksmithing,
    Ceramics
}

public class Elf(string name, ElfSpecialty specialty)
{
    public readonly string Name = name;
    public readonly ElfSpecialty Specialty = specialty;
}
