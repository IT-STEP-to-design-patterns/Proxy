using System;
using System.IO;

namespace Logger
{
    public class FileLog : ILog
    {
        private readonly string _path;
        
        public FileLog(string path)
        {
            _path = path;
        }

        private void Write(string message)
        {
            using var file = new StreamWriter(_path, true);
            file.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            var msg = $"{DateTime.Now:g} [INFO] {message}";
            Write(msg);
        }

        public void LogError(string message)
        {
            var msg = $"{DateTime.Now:g} [ERROR] {message}";
            Write(msg);
        }

        public void LogWarning(string message)
        {
            var msg = $"{DateTime.Now:g} [WARNING] {message}";
            Write(msg);
        }

        public void LogSuccess(string message)
        {
            var msg = $"{DateTime.Now:g} [SUCCESS] {message}";
            Write(msg);
        }

        public void Log(string type, string message)
        {
            var msg = $"{DateTime.Now:g} [{type.ToUpper()}] {message}";
            Write(msg);
        }
    }
}