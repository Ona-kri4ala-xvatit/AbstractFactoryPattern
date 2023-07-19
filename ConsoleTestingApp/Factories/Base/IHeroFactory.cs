using ConsoleTestingApp.Models.Base;

namespace ConsoleTestingApp.Factories.Base
{
    public interface IHeroFactory
    {
        IMovement CreateMovement();
        IWeapon CreateWeapon();
    }
}
