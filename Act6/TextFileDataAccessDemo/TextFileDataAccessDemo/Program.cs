using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextFileDataAccessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Work\test.txt";
            List<Person> people = new List<Person>();
            List<String> lines = File.ReadAllLines(path).ToList();

            foreach (String line in lines)
            {
                string[] entries = line.Split(", ");

                Person p = new Person();
                p.firstName = entries[0];
                p.lastName = entries[1];
                p.occupation = entries[2];

                people.Add(p);
            }
            Person m = new Person();
            m.firstName = "Michael";
            m.lastName = "Perry";
            m.occupation = "Lil brat";
            people.Add(m);

            Console.Out.WriteLine("Here are my people");
            List<String> outlines = new List<String>();
            
            foreach (Person p in people)
            {
                Console.Out.WriteLine("First name: " + p.firstName + ", last name: " + p.lastName + ", occupation: " + p.occupation);

                outlines.Add("First name: " + p.firstName + ", last name: " + p.lastName + ", occupation: " + p.occupation);
            }

            string outpath = @"D:\Work\outTest.txt";
            File.WriteAllLines(outpath, outlines);

            Console.ReadLine();
        }
    }
}
