using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworklesson7_25_09
{
    class Microwave : Device
    {
        public string Brand { get; set; }
        public Microwave(string name, string brand) : base(name)
        {
            Brand = brand;
        }

        public override void Sound()
        {
            Console.WriteLine($"{Brand} {Name}: Squeaks.");
        }
    }
}
