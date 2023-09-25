using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworklesson7_25_09
{
    internal class Car : Device
    {
        public string Make { get; set; }
        public Car(string name, string make) : base(name)
        {
            Make = make;
        }

        public override void Sound()
        {
            Console.WriteLine($"{Make}{Name}: The motor is running.");
        }

        public override void Desc()
        {
            Console.WriteLine($"Description of the car:{Make} {Name}");
        }
    }
}
    
