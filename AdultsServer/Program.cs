using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdultsServer.Models;
using AdultsServer.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AdultsServer
{
    public class Program
    {
        public static void Main(string[] args)
         {
        using (AdultContext adultContext = new AdultContext())
        {
            if (!adultContext.Adults.Any())
            {
                Seed(adultContext);
            }
        }
            CreateHostBuilder(args).Build().Run();
        }
        
private static void Seed(AdultContext adultContext)
{

            Adult a = new Adult()
            {
                Job = new Job(){
                    JobTitle = "Cat",
                    Salary = 4000
                },
                Id = 0,
                Height = 174,
                Age = 58,
                FirstName = "Yasmine",
                Sex = "F",
                EyeColor = "Brown",
                HairColor = "Black",
                LastName = "Baxter",
                Weight = 39.8
            };
            Adult a9 = new Adult()
            {
                Job = new Job(){
                    JobTitle= "Rabbit",
                    Salary= 6000
                },
                Id = 0,
                Height = 147,
                Age = 36,
                FirstName = "Lyla",
                Sex = "F",
                EyeColor = "Brown",
                HairColor = "Black",
                LastName = "Humphrey",
                Weight = 64.8
            };
            Adult a8 = new Adult()
            {
                Job = new Job(){
                    JobTitle= "Make up Artist",
                    Salary= 8000
                },
                Id = 0,
                Height = 145,
                Age = 34,
                FirstName = "Samara",
                Sex = "F",
                EyeColor = "Brown",
                HairColor = "Black",
                LastName = "Humphrey",
                Weight = 37
            };
            Adult a7 = new Adult()
            {
                Job = new Job(){
                    JobTitle= "Trainer",
                    Salary= 2000
                },
                Id = 0,
                Height = 167,
                Age = 59,
                FirstName = "Chaya",
                Sex = "F",
                EyeColor = "Brown",
                HairColor = "Black",
                LastName = "Mcclure",
                Weight = 32.4
            };
            Adult a6 = new Adult()
            {
                Job = new Job(){
                    JobTitle= "Cleaner",
                    Salary= 4000
                },
                Id = 0,
                Height = 172,
                Age = 50,
                FirstName = "Ophelia",
                Sex = "F",
                EyeColor = "Brown",
                HairColor = "Black",
                LastName = "Nathan",
                Weight = 106
            };
            Adult a5 = new Adult()
            {
                Job = new Job(){
                    JobTitle= "Driver",
                    Salary= 7000
                },
                Id = 0,
                Height = 177,
                Age = 48,
                FirstName = "Soham",
                Sex = "M",
                EyeColor = "Grey",
                HairColor = "Black",
                LastName = "Fitzgerald",
                Weight = 131.6
            };
            Adult a4 = new Adult()
            {
                Job = new Job(){
                JobTitle= "Teacher",
                    Salary= 40004
                },
                Id = 0,
                Height = 147,
                Age = 44,
                FirstName = "Anastasia",
                Sex = "F",
                EyeColor = "Brown",
                HairColor = "Black",
                LastName = "Fitzgerald",
                Weight = 99.8
            };
            Adult a3 = new Adult()
            {
                Job = new Job(){
                    JobTitle= "Dog",
                    Salary= 4000
                },
                Id = 0,
                Height = 172,
                Age = 52,
                FirstName = "Cataleya",
                Sex = "F",
                EyeColor = "Blue",
                HairColor = "Blond",
                LastName = "Mcintyre",
                Weight = 56.8
            };
            Adult a2 = new Adult()
            {
                Job = new Job(){
                    JobTitle= "Painter",
                    Salary= 5000
                },
                Id = 0,
                Height = 148,
                Age = 42,
                FirstName = "Andi",
                Sex = "F",
                EyeColor = "Amber",
                HairColor = "Brown",
                LastName = "Wells",
                Weight = 27.6
            };
               Adult a1=new Adult()
                 {
                     Job = new Job(){
                         JobTitle= "Engineer",
                         Salary= 40000
                     },
                     Id = 0,
                     Height = 164,
                     Age = 46,
                     FirstName = "Genevieve",
                     Sex = "F",
                     EyeColor = "Brown",
                     HairColor = "Leverpostej",
                     LastName = "Cruz",
                     Weight = 102.5
                 };
             adultContext.Add(a);
             adultContext.Add(a1);
             adultContext.Add(a2);
             adultContext.Add(a3);
             adultContext.Add(a4);
             adultContext.Add(a5);
             adultContext.Add(a6);
             adultContext.Add(a7);
             adultContext.Add(a8);
             adultContext.Add(a9);
             adultContext.SaveChanges();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}