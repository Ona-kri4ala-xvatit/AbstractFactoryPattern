using ConsoleTestingApp.Factories.Base;
using ConsoleTestingApp.Models.Base;
using ConsoleTestingApp.Models.Movement;
using ConsoleTestingApp.Models.Weapon;

namespace ConsoleTestingApp.Factories
{
    public class ElfHeroFactory : IHeroFactory
    {
        public IMovement CreateMovement()
        {
            return new Fly();
        }

        public IWeapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
