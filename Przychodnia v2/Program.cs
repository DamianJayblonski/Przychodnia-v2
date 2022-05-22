using Przychodnia_v2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            using (var databaseDJ = new PacjentContext())
            {
                /*
                databaseDJ.Add(new Pacjent() { 
                    Nazwisko = "Kowalski", 
                    Imie = "Antoni", 
                    Adres = "ul. Błotna numer zachloapany Krakow woj. Mał",
                    DataUrodzenia = new DateTime(1976, 1, 18, 0, 0, 0),
                    Plec = "M",
                    Pesel = "76011812222"
                });
               

                databaseDJ.Add(new RodzajZabiegu()
                {
                    Nazwa = "Laser",
                    Numer = "01-LSR",
                });

                databaseDJ.Add(new RodzajZabiegu()
                {
                    Nazwa = "Masaż",
                    Numer = "02-M45",
                });

                databaseDJ.Add(new RodzajZabiegu()
                {
                    Nazwa = "Akupunktura",
                    Numer = "03-APK",
                });

                databaseDJ.Add(new RodzajZabiegu()
                {
                    Nazwa = "Ostre Ciecie",
                    Numer = "04-OCC",
                });

                databaseDJ.SaveChanges();

                */
            }

            Console.WriteLine("Finished");

        }
    }
}