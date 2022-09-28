using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LKW : Vehicle
    {
        public LKW(string name, string color, int speed, int ps)
        {
            Name = name;
            Color = color;
            Speed = speed;
            PS = ps;
        }
        public void Hupen()
        {
            Console.WriteLine("Möchtest du Hupen und überrascht werden was passiert(y/n)");
            string answerLKW = Console.ReadLine();
            if(answerLKW == "y")
            {
                Console.WriteLine("Dein LKW hupt und das Geräusch dabei sorgt für lachen!");
            }
            else if (answerLKW == "n")
            {
                Console.WriteLine("Was ein langweiler!");
            }
        }

    }
}
