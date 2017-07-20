using IMQ1.HTTP.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMQ1.HTTP.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string urlPath = "https://calendar.google.com/";
            const string folderPath = @"D:\SomethingGoesGOOD\";

            var callTask = Task.Run(() => CustomWget.DownloadAsync(urlPath, folderPath, 2, DomainRestriction.NoRestriction, true));
            callTask.Wait();
        }
    }
}
