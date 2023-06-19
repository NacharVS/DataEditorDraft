using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEditor.Models
{
    internal class EmpoyeeCard
    {
        public EmpoyeeCard(string nameOfEmpoyee, string vacancy)
        {
            NameOfEmpoyee = nameOfEmpoyee;
            Vacancy = vacancy;
        }

        public string NameOfEmpoyee { get; set; }
        public string Vacancy { get; set; }

        public static List<EmpoyeeCard> GetCards()
        {
            var list = new List<EmpoyeeCard>();
            list.Add(new EmpoyeeCard("Helga", "Manager"));
            list.Add(new EmpoyeeCard("John", "Meteorologist"));
            return list;
        }
    }
}
