using Loto7.Controllers;

namespace Loto7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var controller = new SevenController();
            controller.Get();
        }
    }
}