using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt10
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthdayDate { get; set; }

        public int GetDaysOfLive() 
        {
            return (int)Math.Floor((DateTime.Now - BirthdayDate).TotalDays);
        }

        public override string ToString()
        {
            return $"{Name} {Surname}, Народився : {BirthdayDate.ToShortDateString()}";
        }
    }
}
