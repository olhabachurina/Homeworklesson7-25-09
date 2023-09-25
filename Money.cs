using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworklesson7_25_09
{
    internal class Money
    {
        public int Hryvnia  {get ; set;}
        public int Kopecks { get; set; }

        public Money(int hryvnia, int kopecks)
        {
            Hryvnia = hryvnia;
            Kopecks = kopecks;
        }

        public void Display()
        {
            Console.WriteLine($"{Hryvnia} UAH. {Kopecks} kop.");
        }

        public void SetValue(int hryvnia, int kopecks)
        {
            Hryvnia = hryvnia;
            Kopecks = kopecks;
        }

        public void Add(int hryvnia, int kopecks)
        {
            Hryvnia += hryvnia;
            Kopecks += kopecks;
            if (Kopecks >= 100)
            {
                Hryvnia += Kopecks / 100;
                Kopecks %= 100;
            }
        }

        public void Subtract(int hryvnia, int kopecks)
        {
            if (Kopecks < kopecks)
            {
                Hryvnia -= (hryvnia + 1);
                Kopecks += 100 - kopecks;
            }
            else
            {
                Hryvnia -= hryvnia;
                Kopecks -= kopecks;
            }
        }
    }

}

