using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Delegates
{

    public class SportCar:Car
    {
        int Finish = 10000;
        int Mills = 0;
        int Time = 200;
        public override int RacingAuto()
        {
            base.RacingAuto();
            return SpeedAuto;
        }
        
        public override void Winner()
        {
            Console.WriteLine("You are winner!!!");
            Console.WriteLine($"Last Moment Speed: {SpeedAuto}");
            Console.WriteLine($"Mills: {Mills}");
            Console.WriteLine($"Time : {Time}");
        }
        public int GetFinish()
        {

            while (Time > 0)
            {


                if (RacingAuto() > 0 && SpeedAuto < 300)
                {

                    Mills = Mills + SpeedAuto;
                    Time--;
                    Console.WriteLine(Time);

                }
                if (RacingAuto() > 300)
                {

                    Random rnd = new Random();
                    SpeedAuto = SpeedAuto - RacingAuto();
                    Time--;
                    Console.WriteLine(Time);
                }
                if (RacingAuto() < 0)
                {
                    Console.WriteLine("Stop"); SpeedAuto = 0;
                    Time--;
                    Console.WriteLine(Time);
                }
                if (Mills > Finish)
                {
                    
                    break;
                }
                if (Time == 0)
                {
                    Console.WriteLine("Время вышло!");
                }

            }



            return Mills;
        }
      
    }
}
