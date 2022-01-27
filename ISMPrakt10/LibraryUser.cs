using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt10
{
    public class LibraryUser : Human
    {
        public int ReaderNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int Contribution { get; set; }
        public LibraryUser(string name, string surname, DateTime date, 
            int readerNumb, DateTime dateOfIssue, int contribution) : base(name, surname, date)
        {
            ReaderNumber = readerNumb;
            DateOfIssue = dateOfIssue;
            Contribution = contribution;
        }

        public int ContributionPerYear() 
        {
            return 12 * Contribution;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nReaderNumber: {ReaderNumber}\nDateOfIssue: " +
                $"{DateOfIssue.ToShortDateString()}\nContribution: {Contribution}\n";
        }
    }
}
