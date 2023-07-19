using ConsoleTestingApp.Factories.Base;
using ConsoleTestingApp.Models.Base;
using ConsoleTestingApp.Models.Movement;
using ConsoleTestingApp.Models.Weapon;

namespace ConsoleTestingApp.Factories
{
    public class WarriorHeroFactory : IHeroFactory
    {
        public IMovement CreateMovement()
        {
            return new Run();
        }

        public IWeapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
