using System;

namespace Logger.Test
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Варианты логгирования:");
            Console.WriteLine("1. На консоль");
            Console.WriteLine("2. В файл");
            Console.Write("Выберите вариант логгирования - ");
            var select = Console.ReadLine();
            ILog log = select switch
            {
                "1" => new ConsoleLog(),
                "2" => new FileLog("test.log"),
                _ => null
            };
            
            TestLog(log);
        }

        private static void TestLog(ILog log)
        {
            log.LogInfo("Старт метода");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    log.LogError("Чётное число");
                }
                else
                {
                    log.LogWarning("Нечётное число");
                }
            }
            log.LogSuccess("Метод завершён");
            
            log.Log("Test", "Тест");
        }
    }
}