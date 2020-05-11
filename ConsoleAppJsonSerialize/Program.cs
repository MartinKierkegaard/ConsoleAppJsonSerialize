using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleAppJsonSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        

            student st = new student("Martin","Roskilde");

            string json = JsonConvert.SerializeObject(st);
            Console.WriteLine(json);
            List<student> listStudent = new List<student>();

            listStudent.Add(st);
            listStudent.Add(new student("Anders And", "AndeBy"));
            listStudent.Add(new student("Andersine", "AndeBy"));

            string jsonliste = JsonConvert.SerializeObject(listStudent);
            
            Console.WriteLine(jsonliste);

            string jsonobject = "{\"navn\":\"Martin\",\"adresse\":\"Roskilde\"}";

            student st_deserialise = new student();

            st_deserialise = JsonConvert.DeserializeObject<student>(jsonobject);

            Console.WriteLine("Deserialize");

            Console.WriteLine(st_deserialise);

            string jsonlistestudent = "[{\"navn\":\"Martin\",\"adresse\":\"Roskilde\"},{\"navn\":\"Anders And\",\"adresse\":\"AndeBy\"},{\"navn\":\"Andersine\",\"adresse\":\"AndeBy\"}]";

            List<student> list_deserialize = JsonConvert.DeserializeObject<List<student>>(jsonlistestudent);

            foreach (var student in list_deserialize)
            {
                Console.WriteLine(student);
            }


            
            

        }
    }
}
