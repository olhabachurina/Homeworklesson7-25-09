using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworklesson7_25_09
{
    internal class Steamship : Device
    {
        public string Brand { get; set; }
        public Steamship(string name, string brand) : base(name)
        {
            Brand = brand;
        }

        public override void Sound()
        {
            Console.WriteLine($"{Brand}{Name}: The steamer hums and smokes.");
        }

        public override void Desc()
        {
            Console.WriteLine($"Description of the ship:{Brand} {Name}");
        }
    }
}
