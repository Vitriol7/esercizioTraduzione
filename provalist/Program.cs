using System;
using System.IO;
using System.Collections.Generic;
using CsvHelper;
using System.Globalization;
using provalist.Models;


namespace provalist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dichiarizione variabili path//
            string peoplePath = @"C:\\clogs\\people.csv";
            string peopleLogPath = @"C:\\clogs\\log.csv";



            List<People> listPeoples = new List<People>()
            {
                new People
                {
                    Name = "Marco",
                    Id= 1,
                    IsFavorite= true,
                },
                new People
                {

                    Name = "Manuele",
                    Id= 2,
                    IsFavorite= true,
                },
                new People
                {
                  Name = "Bruno",
                    Id= 3,
                    IsFavorite= true,


                }

            };
            List<Log> listLog = new List<Log>()
            {
                new Log { ErrorCode = 404, Message= " error 404", timeOfEvent= DateTime.Now},
                new Log { ErrorCode = 102, Message= " error 102", timeOfEvent= DateTime.Now},
                new Log { ErrorCode = 202, Message= "error 202", timeOfEvent= DateTime.Now},
                new Log { ErrorCode = 600, Message= " error 600", timeOfEvent= DateTime.Now},
                new Log { ErrorCode = 329, Message= " error 329", timeOfEvent= DateTime.Now},

            };

            scriviCsv<People>(listPeoples, peoplePath);
            Console.WriteLine();
            scriviCsv<Log>(listLog, peopleLogPath);
            print(peoplePath);
            print(peopleLogPath);


        }
        

        
        //csv writer
        static void scriviCsv<T>(List<T> lista, string path)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(lista);
            }
        }
        // csw print
        static void print(string path)
        {
            FileInfo fi = new FileInfo(path);
            StreamReader sr = fi.OpenText();
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
