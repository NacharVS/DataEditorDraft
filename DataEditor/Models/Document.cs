using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEditor.Models
{
    internal class Document
    {
        public Document(int number, string context, string name)
        {
            Name = name;
            Number = number;
            Context = context;
            
        }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Context { get; set; }

        public static List<Document> GetDocuments()
        {
            var list = new List<Document>();
            list.Add(new Document(223, "Blank of products", "Blank"));
            list.Add(new Document(2541, "Bank Check", "Check"));
            list.Add(new Document(11, "Agreement of personal data", "Agreement"));
            return list;

        }

        //public List<Document<string,R>> Fields;

        //public void AddDocuments<T, R>(T par1, R par2, string name)
        //{
        //    Fields.Add(new Document<T, R>(par1, par2, name));                      
        //}
    }
}
