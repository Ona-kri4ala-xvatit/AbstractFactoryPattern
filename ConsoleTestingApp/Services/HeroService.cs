using ConsoleTestingApp.Factories.Base;
using ConsoleTestingApp.Models.Base;

namespace ConsoleTestingApp.Services
{
    public class HeroService
    {
        private IMovement movement;
        private IWeapon weapon;

        public HeroService(IHeroFactory heroFactory)
        {
            movement = heroFactory.CreateMovement();
            weapon = heroFactory.CreateWeapon();
        }

        public void Movement()
        {
            movement.Move();
        }

        public void Hit()
        {
            weapon.Hit();
        }
    }
}
