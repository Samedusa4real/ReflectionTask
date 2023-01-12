using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Models
{
    internal class Piano : Instrument
    {
        public int Keys { get; set; }
        public override void Sound()
        {
            Console.WriteLine("Piano sounds like mellow!");
        }
    }
}
