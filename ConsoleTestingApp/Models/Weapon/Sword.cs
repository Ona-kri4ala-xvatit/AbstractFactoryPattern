using ConsoleTestingApp.Models.Base;

namespace ConsoleTestingApp.Models.Weapon
{
    public class Sword : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("15 Hit");
        }
    }
}
