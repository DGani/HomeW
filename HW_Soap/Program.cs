using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Runtime.Serialization.Formatters.Soap;

namespace HW_Soap

{
    public  class Person
    {
        public string Name { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public int Year { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            List<Person> persons = new List<Person>();
            string[] fields;
            try
            {
                using (TextFieldParser parser = new TextFieldParser(@"C:\Users\dgani\Documents\Visual Studio 2015\Projects\HW_Soap\HW_Soap\1.csv"))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {

                        fields = parser.ReadFields();
                        foreach (string item in fields)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error CSV");
            }
            try
            {
                SoapFormatter formatter = new SoapFormatter();
                using (FileStream fs = new FileStream("people.soap", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, fields);

                    Console.WriteLine("Объект сериализован");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error SOAP");
            } 

            Console.ReadLine();
        }
        
    }
}
