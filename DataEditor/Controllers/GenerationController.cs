using DataEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DataEditor.Controllers
{
    internal class GenerationController
    {
       public static List<Document> SendDocuments()
        {
            if (Document.GetDocuments() != null)
            {
                return Document.GetDocuments();
            }
            else
                return null;
        }

        public static List<string> SendDocNames()
        {
            var names = new List<string>();
            if (Document.GetDocuments() != null)
            {
                foreach (var document in Document.GetDocuments())
                {
                    names.Add(document.Name);
                }
                return names;
            }
            else
                return null;
        }
        public static List<EmpoyeeCard> SendCards()
        {
            return EmpoyeeCard.GetCards();
        }

        public static void GetSingleDocument(Label lName, Label lType, Label lValue, string key)
        {
            var doc = Document.GetDocuments().Find(x => x.Name == key);
            Type type = doc.GetType();
            PropertyInfo info = type.GetProperty("Name");
            lName.Content = info.Name;
            lType.Content = info.PropertyType.Name;
            lValue.Content = doc.Name;
        }

    }
}
