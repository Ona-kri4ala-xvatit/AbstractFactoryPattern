using ConsoleTestingApp.Models.Base;

namespace ConsoleTestingApp.Models.Movement
{
    public class Run : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Runnig");
        }
    }
}
