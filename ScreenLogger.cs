namespace Dependency_Inversion_Principle
{
    public class ScreenLogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Message: {0}", message);
        }
    }
}