using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DogHeathRecord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Emphasis on the program where the owner can run the proram so the owner can keep track on dog's health,
           + dogs vaccine, and vet contact info
             */
            Console.WriteLine("Welcome to Dog Health Record");


            





        }

        private static bool menuoption
        {
            
            Console.Writeline(" Main Menu")
            Console.Writeline
        }
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
