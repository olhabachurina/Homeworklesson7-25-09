using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworklesson7_25_09
{
     class Kettle : Device
    {
        public string Brand { get; set; }
        public Kettle(string name, string brand) : base(name)
        {
            Brand = brand;
        }

        public override void Sound()
        {
            Console.WriteLine($"{Brand} {Name}: Steam rises.");
        }
    }
}
