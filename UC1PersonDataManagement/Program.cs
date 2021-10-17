using System;
using System.Collections.Generic;

namespace UC1PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listperson = new List<Person>();
            AddRecords(listperson);
        }
        private static void AddRecords(List<Person> listperson)
        {
            listperson.Add(new Person("121212", "Amit", "12 main road", 14));
            listperson.Add(new Person("222222", "Krishna", "15 main road", 13));
            listperson.Add(new Person("333333", "Lala", "32 main road", 11));
            listperson.Add(new Person("444444", "Sumit", "82 main road", 18));
            listperson.Add(new Person("555555", "Satty", "98 main road", 24));
        }
    }
}
