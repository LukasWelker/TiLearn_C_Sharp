using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Motorrad : Vehicle
    {
        public Motorrad(string name, string color, int speed, int ps)
        {
            Name = name;
            Color = color;
            Speed = speed;
            PS = ps;
        }
        public void Wheelie()
        {
            if (PS >= 120)
            {
                Console.WriteLine("Dein Motorrad hat die Fähigkeit einen Wheelie durchzuführen! Möchtest du einen Wheelie durchführen ?(y/n)");
                string answer = Console.ReadLine();
                if(answer == "y")
                {
                    Console.WriteLine("Alles klar dein Motorrad führt nun einen Wheelie durch");
                    Speed += 10;
                    Console.WriteLine("Deine geschwindigkeit ehröht sich hierbei um 10 km/h:");
                }  
            }
            else
            {
                Console.WriteLine("Dein Motorrad ist leider zu schwach um einen Wheelie durchzuführen");
            }
        }
    }
}
