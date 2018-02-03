using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Delegates
{
    class Program
    {
       
        

        static void Main(string[] args)
        {
            SportCar formula1 = new SportCar();
            formula1.NameAuto = "Mitshubishi";
            PassengerCar Vanya = new PassengerCar();
            Vanya.NameAuto = "Toyota";
            Car.ShowCharacters method = Show;
            formula1.Eventt += formula1.Winner;
            Vanya.Eventt += Vanya.Winner;
            while (true)
            {
               formula1.RacingAuto();
                Vanya.RacingAuto();
             if (formula1.GetFinish() > 10000)
                {
                    Console.WriteLine("Winner Formula 1");
                    //formula1.Eventt; не смог(
                    break;              
                }
                if (Vanya.GetFinish() > 10000)
                {
                    Console.WriteLine("Winner Vasya");
                   // Vanya.Eventt;
                    break;
                  
                }
            }
            Console.WriteLine("-------------------");
            Console.Write("Марка первого авто: ");
            formula1.Characters(method);
            Console.Write("Марка второго авто: ");
            Vanya.Characters(method);
            Console.ReadLine();
        }
        static void Show(string message)
        {
            Console.WriteLine(message);
        }

    }
}
