﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace UC3PersonDataBetween13to18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listperson = new List<Person>();
            AddRecords(listperson);
            RetrevingAgebetween13And18(listperson);
        }
        private static void AddRecords(List<Person> listperson)
        {
            listperson.Add(new Person("121212", "Amit", "12 main road", 14));
            listperson.Add(new Person("222222", "Krishna", "15 main road", 13));
            listperson.Add(new Person("333333", "Lala", "32 main road", 61));
            listperson.Add(new Person("444444", "Sumit", "82 main road", 18));
            listperson.Add(new Person("555555", "Satty", "98 main road", 24));
        }
        private static void RetrevingAgebetween13And18(List<Person> listperson)
        {
            foreach (Person person in listperson.FindAll(x => (x.Age > 13 && x.Age < 18)).Take(2).ToList())
            {
                Console.WriteLine("Name " + person.Name + " (Age)" + person.Age);
            }
        }
    }
}
