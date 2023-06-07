namespace Dependency_Inversion_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ScreenLogger();

            var operations = new MathoOperations(logger);

            operations.Add(1,5);
            operations.Subtract(10,2);
        }
    }
}