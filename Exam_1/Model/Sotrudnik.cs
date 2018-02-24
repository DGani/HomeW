using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1
{
    [Serializable]
    public class Sotrudnik:ISotrudnik
    {
        public string FIO { get; set; }
        public int ID { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public Sotrudnik() { }
        public Sotrudnik(string fio,int id, int age, string position, string department)
        {
            FIO = fio;
            ID = id;
            Position = position;
            Age = age;
            Department = department;
        }
        public void PrintS()
        {
            Console.WriteLine($"FIO: {FIO}, ID: {ID}  Position:  {Position }, Age: {Age}, Department {Department} ");
        }



    }
}
