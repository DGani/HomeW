using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Delegates
{
  
    

    public abstract class Car
    {
        public string NameAuto { get; set; }
        public int SpeedAuto { get; set; }
        public delegate void ShowCharacters(string method);
        public delegate void ShowWinner();
        public virtual void Winner() { }
      
        public virtual int RacingAuto() { 
            Random rnd = new Random();
            SpeedAuto = SpeedAuto + rnd.Next(0, 50);
            return SpeedAuto;
        }
     
        public void Characters(ShowCharacters method)
        {
            method(string.Format(NameAuto));
        }
        public event ShowWinner Eventt;
    }
}
