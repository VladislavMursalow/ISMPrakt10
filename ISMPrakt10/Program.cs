using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ISMPrakt10
{
    class Program
    {
        static Dictionary<string, int> marks;
       
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            marks = new Dictionary<string, int>();

            initMarks();

            //write entrants in list
            humans.Add(new Entrant("ABOBA", "ABOBOVICH", new DateTime(2003, 1, 6), marks, 10, "SOME SCHOOL 1"));
            ReGenerateRandomMarks();
            humans.Add(new Entrant("GEORGE", "GEOGROVICH", new DateTime(1980, 5, 12), marks, 10, "SOME SCHOOL 2"));
            ReGenerateRandomMarks();
            humans.Add(new Entrant("VASIL", "VASILOVICH", new DateTime(2005, 7, 15), marks, 10, "SOME SCHOOL 3"));

            //write Students in list
            humans.Add(new Student("VLADISLAV", "MURSALOW", new DateTime(2003, 1, 1), "FIKT", "KI-20-1", "ZDTU", 2));
            humans.Add(new Student("IVANOV", "IVANOVICH", new DateTime(2002, 9, 1), "FIKT", "IPZ-19-1", "ZDTU", 3));
            humans.Add(new Student("MARK", "TSUKERBERG", new DateTime(1999, 5, 21), "FIKT", "BI-20", "ZDTU", 1));

            //write Teachers in list
            humans.Add(new Teacher("PETRO", "PETROVICH", new DateTime(1959, 1, 1), "KPI", "ГЕРОЙ АССЕМБЛЕРНИХ НАУК","FIKT"));
            humans.Add(new Teacher("PETRO", "PETROSYANOVICH", new DateTime(1971, 6, 29), "KNU", "КАНДИТАТ ТЕХНИЧНИХ НАУК","FIKT"));
            humans.Add(new Teacher("MIRANDA", "TSUSIMOVNA", new DateTime(1999, 8, 11), "KNU", "СТРАШИЙ ВИКЛАДАЧ КАФЕДРИ ФІЛОСОФІЇ","PA"));

            //write LibraryUsers in list
            humans.Add(new LibraryUser("PETRO", "PETROVICH", new DateTime(1959, 1, 1), 111111, DateTime.Now, 500));
            humans.Add(new LibraryUser("PETRO", "PETROSYANOVICH", new DateTime(1971, 6, 29), 222222, DateTime.Now, 200));
            humans.Add(new LibraryUser("MIRANDA", "TSUSIMOVNA", new DateTime(1999, 8, 11), 333333, DateTime.Now, 300));
            DangerOutput("====================HUMANS====================");
            OutputAllHumans(humans);

            DangerOutput("=================SPECIAL FUNKS================");
            CheckoutFunctions(humans);
        }
        static public void CheckoutFunctions(List<Human> humans) 
        {
            foreach (Human h in humans)
            {
                if(h is Entrant)
                    Console.WriteLine(h.Name + " " + h.Surname + "AVG ZNO:" + (h as Entrant).GetAvgfMarkFromZNO());

                if (h is Student)
                    Console.WriteLine((h as Student).GetOnlyUniversityData());
                if (h is Teacher)
                    Console.WriteLine((h as Teacher).GetOnlyUniversityData());
                if (h is LibraryUser)
                    Console.WriteLine(h.Name + " " + h.Surname + (h as LibraryUser).ContributionPerYear());
            }
        }
        static public void DangerOutput(string massage) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(massage);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static public void OutputAllHumans(List<Human> humans) 
        {
            foreach (Human h in humans)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine(h);
            }
        }

        static public int GetRandomMark()
        {
           
            Random r = new Random();
            return r.Next(0,100);
        }

        

        static public void ReGenerateRandomMarks() 
        {
            foreach (string key in marks.Keys) 
            {
                marks[key] = GetRandomMark();
            }
        }

        static public void initMarks() 
        {
            marks.Add("UKR. MOVA", GetRandomMark());
            marks.Add("MATH", GetRandomMark());
            marks.Add("GEOGRAPHY", GetRandomMark());
            marks.Add("CHEMISTRY", GetRandomMark());
        }


    }
}
