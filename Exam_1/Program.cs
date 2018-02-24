using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exam_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sotrudnik> sotrudniki = new List<Sotrudnik>();
            sotrudniki.Add(new Sotrudnik("Ivanov Ivan Ivanovich",1011,51,"Head" ,"Director"));
            sotrudniki.Add(new Sotrudnik( "Puhareva Mariya Alekssevna", 1051,  47,  "Head",  "TOP Manager" ));
            sotrudniki.Add(new Sotrudnik( "Patin Denis", 1077, 26,  "IT",  "Programmer" ));
            sotrudniki.Add(new Sotrudnik("Mirin Arman", 1089, 30,  "Accounters",  "Accounter" ));
            sotrudniki.Add(new Sotrudnik( "Platonov Gosha",1701, 20, "Front",  "Driver" ));
            sotrudniki.Add(new Sotrudnik( "Kutsin Aidar",1702,23, "Front",  "Manager" ));
            sotrudniki.Add(new Sotrudnik("Aidarov Manarbek",1703, 20,  "Front", "Saler" ));

            sotrudniki.Sort(delegate (Sotrudnik a, Sotrudnik b)
            {
                return a.ID.CompareTo(b.ID);
            });

            LogicForSotrudnik logica = new LogicForSotrudnik();

          Console.WriteLine("List of Workers");
            foreach (var item in sotrudniki)
            {
                item.PrintS();
            }
            Console.WriteLine("Add Worker");
            sotrudniki.Add(logica.newsSotrudni());

            Console.WriteLine("List of Workers");
            foreach (var item in sotrudniki)
            {
                item.PrintS();
            }

            Console.WriteLine("Remove Worker");
            sotrudniki.Remove(logica.removeSotrudnik(sotrudniki));

            Console.WriteLine("List of Workers");
            foreach (var item in sotrudniki)
            {
                item.PrintS();
            }
            Console.WriteLine("Find Worker");
            logica.FindS(sotrudniki).PrintS();
            
            Console.WriteLine("Statistic Workers");
            logica.Statistic(sotrudniki);
            logica.SerializeAll(sotrudniki);

         
            Console.ReadLine();
        }



    }
}
