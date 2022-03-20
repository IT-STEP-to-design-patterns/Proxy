namespace Logger
{
    public interface ILog
    {
        public void LogInfo(string message);
        public void LogError(string message);
        public void LogWarning(string message);
        public void LogSuccess(string message);
        
        public void Log(string type, string message);
    }
}