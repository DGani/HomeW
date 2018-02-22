using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace HW_Json
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name, int year)
            {
                Name = name;
                Age = year;
            }
        }
        static void Main(string[] args)
        {

            Person person = new Person("Mike", 22);

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Person[]));

            using (FileStream fs = new FileStream("Mike.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, person);
            }

            using (FileStream fs = new FileStream("Mike.json", FileMode.OpenOrCreate))
            {
                Person[] newperson = (Person[])jsonFormatter.ReadObject(fs);

                foreach (Person p in newperson)
                {
                    Console.WriteLine("Имя: {0} --- Возраст: {1}", p.Name, p.Age);
                }
            }

            Console.ReadLine();
        }
    }
}
