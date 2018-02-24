using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exam_1
{
    class Logins:Directory
    {
       
        public string LoginEnter()
        {
            Console.WriteLine("Enter you login");
            string login = Console.ReadLine();
            Console.WriteLine("Enter you pasword");
            string password = Console.ReadLine();
            Console.WriteLine("Enter you department");
            string department = Console.ReadLine();
            return department;
        }

        public string  checkAccsess(string department)
        {
            if (department == "IT" || department =="Head") return "High";
            if (department == "Accounters") return "Medium";
            else return "Low";
        }

    }
}
