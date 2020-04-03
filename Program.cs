using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line, file = "text.txt";
            ArrayList people = new ArrayList();
            using (StreamReader MyFile = new StreamReader(file))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    String[] data = line.Split(' ');
                    if (data.Length == 5)
                    {
                        Person NewPerson = new Person(data[0], data[1], data[2], int.Parse(data[3]), float.Parse(data[4]));
                       people.Add(NewPerson);
                    }
                }
            }
            people.Sort(new PeopleComparer());
            Console.WriteLine("SORTING BY AGE: ");
            for (int i = 0; i != people.Count; i++)
            {
                Console.WriteLine(people[i]);
            }
            Console.ReadKey();
        }
    }
}
