using DataEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEditor.Controllers
{
    internal class GenerationController
    {
       public static List<Document> SendDocuments()
        {
            return Document.GetDocuments();
        }
        public static List<EmpoyeeCard> SendCards()
        {
            return EmpoyeeCard.GetCards();
        }

    }
}
