using System;
using System.Collections.Generic;
using System.Linq;

namespace UC5SpecificNamePresent
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listperson = new List<Person>();
            AddRecords(listperson);
            CheckName(listperson);
        }
        private static void AddRecords(List<Person> listperson)
        {
            listperson.Add(new Person("121212", "Amit", "12 main road", 14));
            listperson.Add(new Person("222222", "Krishna", "15 main road", 13));
            listperson.Add(new Person("333333", "Lala", "32 main road", 61));
            listperson.Add(new Person("444444", "Sumit", "82 main road", 18));
            listperson.Add(new Person("555555", "Satty", "98 main road", 24));
        }
        private static void CheckName(List<Person> listperson)
        {
            if (listperson.Any(x => (x.Name == "Amit")))
            {
                Console.WriteLine("Name is Present");
            }
            else
            {
                Console.WriteLine("Name is Not Present");
            }
        }
    }
}
