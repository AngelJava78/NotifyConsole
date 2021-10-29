using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyConsole
{
    public class ConsoleLog : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
