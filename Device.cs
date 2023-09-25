using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homeworklesson7_25_09
{
    class Device
    {
        public string Name { get; set; }
        public Device(string name)
                {
                Name= name;
            }
       public virtual void Sound()
        {
            Console.WriteLine($"{Name}: Makes a sound.");
        }

        public void Show()
        {
            Console.WriteLine($"Device: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Device Description: {Name}");
        }
    }
}

