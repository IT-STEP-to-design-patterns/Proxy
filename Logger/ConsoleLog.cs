using System;
using System.Collections.Generic;

namespace Logger
{
    public class ConsoleLog : ILog
    {
        private readonly Dictionary<string, ConsoleColor> _colors;
        private string _type;

        public ConsoleLog()
        {
            _colors = new Dictionary<string, ConsoleColor>
            {
                {"info", ConsoleColor.Blue},
                {"success", ConsoleColor.Green},
                {"error", ConsoleColor.Red},
                {"warning", ConsoleColor.Yellow},
                {"default", ConsoleColor.Gray}
            };
        }
        
        public ConsoleLog(Dictionary<string, ConsoleColor> colors)
        {
            _colors = colors;
        }

        private void Show(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
        public void LogInfo(string message)
        {
            _type = "info";
            var msg = $"{DateTime.Now:g} [{_type.ToUpper()}] {message}";
            Show(msg, _colors[_type]);
        }

        public void LogError(string message)
        {
            _type = "error";
            var msg = $"{DateTime.Now:g} [{_type.ToUpper()}] {message}";
            Show(msg, _colors[_type]);
        }

        public void LogWarning(string message)
        {
            _type = "warning";
            var msg = $"{DateTime.Now:g} [{_type.ToUpper()}] {message}";
            Show(msg, _colors[_type]);
        }

        public void LogSuccess(string message)
        {
            _type = "success";
            var msg = $"{DateTime.Now:g} [{_type.ToUpper()}] {message}";
            Show(msg, _colors[_type]);
        }

        public void Log(string type, string message)
        {
            var msg = $"{DateTime.Now:g} [{type.ToUpper()}] {message}";
            Show(msg, _colors["default"]);
        }
    }
}