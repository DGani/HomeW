using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1
{
   public class Directory
    {

        List<string> PositionD = new List<string>();
        List<string> Affiliates = new List<string>(); // филиалы
        List<string> Accesses = new List<string>() { "Low", "Medium", "High" }; // список доступа Low Medium High
        List<string> AccessesForW = new List<string>(); // доступы у сотрудников

        protected void EnterPosition()
        {
            Console.WriteLine("Please enter position");
            PositionD.Add(Console.ReadLine());
        }
        protected void EnterAffiliates()
        {
            Console.WriteLine("Please enter Affiliates");
            Affiliates.Add(Console.ReadLine());
        }
        protected void EnterAccessesForW()
        {
            Console.WriteLine("Please enter AccessesForW");
            AccessesForW.Add(Console.ReadLine());
        }

        protected void ChangeValue(string change, List<string> list)
        {

            Console.WriteLine("Enter what you change");
            string name = Console.ReadLine();
            foreach (var item in list)
            {
                if (item.Contains(name))
                {
                    item.Replace("", name);

                }

            }






        }

        protected void RemoveValue(string remove, List<string> list)
        {

            Console.WriteLine("Enter what you remove");
            string name = Console.ReadLine();
            foreach (var item in list)
            {
                if (item.Contains(name))
                {
                    item.Remove(item.IndexOf(name));
                }

            }
        }

        public void ShowFromAccess()
        {
            Logins log = new Logins();
           string acses = log.checkAccsess(log.LoginEnter());
            if (acses == "High") {
                foreach (var item in PositionD)
                {
                    Console.WriteLine(item);

                }
                foreach (var item in Affiliates)
                {
                    Console.WriteLine(item);
                }
            }

            else if(acses == "Medium")
            {
                foreach (var item in Affiliates)
                {
                    Console.WriteLine(item);
                }
            }
           else
            {
                Console.WriteLine("You don't have an accses!");
            }

        }

    }
}
