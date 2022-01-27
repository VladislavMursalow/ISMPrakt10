using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt10
{
    public class Student: Human
    {
        public string Faculty { get; set; }
        public string Grpoup { get; set; }
        public string University { get; set; }
        public int Course { get; set; }
        public Student(string name, string surname, DateTime date, string faculty, 
            string grpoup, string university, int course) : base(name, surname, date)
        {
            Faculty = faculty;
            Grpoup = grpoup;
            University = university;
            Course = course;
        }

        public string GetOnlyUniversityData() 
        {
            return $"\nFaculty: {Faculty}\nGrpoup: {Grpoup}\n University: {University}\n Course: {Course}\n";
        }

        public override string ToString()
        {
            return base.ToString() + $"\nFaculty: {Faculty}\nGrpoup: {Grpoup}\nUniversity: {University}\nCourse: {Course}\n";
        }
    }
}
