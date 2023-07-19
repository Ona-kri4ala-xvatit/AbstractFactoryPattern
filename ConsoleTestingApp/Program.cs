using ConsoleTestingApp.Factories;
using ConsoleTestingApp.Services;

namespace ConsoleTestingApp;

public class Program
{
    static void Main()
    {
        var Elf = new HeroService(new ElfHeroFactory());
        Elf.Movement();
        Elf.Hit();

        var Warrior = new HeroService(new WarriorHeroFactory());
        Warrior.Movement();
        Warrior.Hit();
    }
}


