using ConsoleTestingApp.Models.Base;

namespace ConsoleTestingApp.Models.Movement
{
    public class Fly : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Flying");
        }
    }
}
