using Przychodnia_v2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var databaseDJ = new PacjentContext())
            {
                databaseDJ.Add(new Pacjent() { Name = "KOWALSKI" });
                databaseDJ.SaveChanges();
            }

            Console.WriteLine("Finished");

        }
    }
}