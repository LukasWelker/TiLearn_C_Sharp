using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PKW : Vehicle
    {
        
      public List<PKW> PKWList;
      
        public PKW(string name, string color, int speed, int ps)
        {
            Name = name;
            Color = color;
            Speed = speed;
            PKWList = new List<PKW>();
        }

        public void SportModus( int wert)
        {
            if(Speed >= 120)
            {
                Console.WriteLine("Dein Auto schaltet jetzt in den Sportmodus");
                foreach(PKW pkw in PKWList)
                {
                    pkw.BeschleunigungUm(wert);
                }
            }
            else 
            {
                Console.WriteLine("Ihr Auto ist noch zu langsam für den Sportmodus");
            }
        }
        
    }
}
