using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

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
