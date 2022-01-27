using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt10
{
    public class Teacher: Human
    {
        public string Positions { get; set; }
        public string Department { get; set; }
        public string University { get; set; }
        public Teacher(string name, string surname, DateTime date, string university,
            string positions, string department) : base(name, surname, date)
        {
            Department = department;
            Positions = positions;
            University = university;
        }

        public string GetOnlyUniversityData()
        {
            return $"\nDepartment: {Department}\nSchool: {Positions}\nUniversity: {University}\n";
        }

        public override string ToString()
        {
            return base.ToString() + $"\nDepartment: {Department}\nSchool: {Positions}\nUniversity: {University}\n";

        }
    }
}
