using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppJsonSerialize
{
    public class student
    {

        public string navn { get; set; }

        public string adresse { get; set; }

        public student(string navn,string adresse)
        {
            this.navn = navn;
            this.adresse = adresse;

        }

        public student()
        {
                
        }

        public override string ToString()
        {
            return $"navn:{navn} adresse:{adresse}";
        }
    }
}
