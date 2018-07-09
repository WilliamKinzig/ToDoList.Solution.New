using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using ToDoList;

namespace ToDoList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()

            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseIISIntegration()
            .UseStartup<Startup>()
            .Build();
            DB.Connection();
            host.Run();
        }
    }
}
