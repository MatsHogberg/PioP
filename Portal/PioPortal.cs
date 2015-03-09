using Microsoft.Owin.Hosting;
using System;

namespace PioPortal
{
    class PioPortal
    {
        static void Main(string[] args)
        {
            const string baseAddress = "http://localhost:8081";
            using (WebApp.Start<StartApi>(url: baseAddress))
            {
                Console.WriteLine("PioAPI running...");
                Console.WriteLine("Press Enter to stop.");
                Console.ReadLine();
            }
        }
    }
}
