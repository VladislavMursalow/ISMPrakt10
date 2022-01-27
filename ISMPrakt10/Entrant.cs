using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt10
{
    public class Entrant : Human
    {
        public Dictionary<string, int> ZNOMarks { get; set; }
        public int AvgOfDocumetMarks { get; set; }
        public string School { get; set; }

        public Entrant(string name, string surname, DateTime date, Dictionary<string, int> ZNOmarks,
            int DocumentsMarks, string school) :base(name,surname, date)
        {
            ZNOMarks = ZNOmarks;
            AvgOfDocumetMarks = DocumentsMarks;
            School = school;
        }

        public int GetAvgfMarkFromZNO() 
        {
            int result = 0;

            foreach (string key in ZNOMarks.Keys)
            {
                result += ZNOMarks[key];

            }

            return result / ZNOMarks.Count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string key in ZNOMarks.Keys) 
            {
                sb.Append($"{key} - {ZNOMarks[key]}\n");
            }

            return base.ToString() + $"\nDocument: {AvgOfDocumetMarks}\nSchool: {School}\n\tMARKS:\n" + sb.ToString();

        }
    }
}
