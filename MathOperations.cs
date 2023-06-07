namespace Dependency_Inversion_Principle
{
    public class MathoOperations
    {
        // High level class, MathOperations, id dependent on the lower level class ScreenLogger.
        // If there is a need to add a new logger, for example a new file logger, then this class needs to be
        // modified which will violate the Open/Close principle of SOLID.
        private readonly ScreenLogger _logger;

        public MathoOperations(ScreenLogger logger) => _logger = logger;

        public double Add(double a, double b) 
        {
            var result = a + b;

            _logger.Log($"{a} + {b} = {result}");

            return result;
        }

        public double Subtract(double a, double b)
        {
            var result = a - b;

            _logger.Log($"{a} - {b} = {result}");

            return result;
        }
    }
}