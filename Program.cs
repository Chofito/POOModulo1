using System;
using System.Collections.Generic;
using POOTarea1.Models;

namespace POOTarea1
{
    class Program
    {
        public static Book DeLaTierraALaLuna { get; set; } = new Book()
        {
            Id = 123456,
            ISBN = "9781980624776",
            Title = "De la tierra a la luna",
            EditionDate = new DateTime(1865, 9, 14),
            Editorial = "Journal des débats politiques et littéraires",
            Authors = new List<string>(){ "Julio Verne" },
            Readed = true,
            TimeReaded = 8
        };

        public static Magazine NationalGeographicMagazine { get; set; } = new Magazine(){
            Id = 654321,
            Title = "The Next Human",
            EditionDate = new DateTime(2017, 4, 1),
            Editorial = "National Geographic Magazine",
            Authors = new List<string>(){ "National Geographic" }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Type => " + DeLaTierraALaLuna.GetType());
            Console.WriteLine("ID: " + DeLaTierraALaLuna.Id);
            Console.WriteLine("ISBN: " + DeLaTierraALaLuna.ISBN);
            Console.WriteLine("Title" + DeLaTierraALaLuna.Title);
            Console.WriteLine("Edition Date: " + DeLaTierraALaLuna.EditionDate.ToShortDateString());
            Console.WriteLine("Editorial: " + DeLaTierraALaLuna.Editorial);
            Console.WriteLine("Authors:");
            foreach (string author in DeLaTierraALaLuna.Authors)
            {
                Console.WriteLine("   " + author);
            }
            Console.WriteLine("Readed: " + DeLaTierraALaLuna.Readed);
            Console.WriteLine("Time Expended: " + DeLaTierraALaLuna.TimeReaded + "\n");

            Console.WriteLine("Type => " + NationalGeographicMagazine.GetType());
            Console.WriteLine("ID: " + NationalGeographicMagazine.Id);
            Console.WriteLine("Title: " + NationalGeographicMagazine.Title);
            Console.WriteLine("Edition Date: " + NationalGeographicMagazine.EditionDate.ToShortDateString());
            Console.WriteLine("Editorial: " + NationalGeographicMagazine.Editorial);
            Console.WriteLine("Authors:");
            foreach (string author in NationalGeographicMagazine.Authors)
            {
                Console.Write("   " + author);
            }
        }
    }
}