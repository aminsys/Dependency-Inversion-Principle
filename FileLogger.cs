namespace Dependency_Inversion_Principle
{
    public class FileLogger: ILogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath) => _filePath = filePath;
        
        public void Log(string message)
        {
            File.AppendAllText(_filePath, "Message: " + message + Environment.NewLine);
        }
    }
}