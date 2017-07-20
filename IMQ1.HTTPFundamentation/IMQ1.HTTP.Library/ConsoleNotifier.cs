using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMQ1.HTTP.Library
{
    public class ConsoleNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
