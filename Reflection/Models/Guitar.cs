using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Models
{
    internal class Guitar : Instrument
    {
        public int Strings { get; set; }
        public string Color { get; set; }
        public override void Sound()
        {
            Console.WriteLine("Guitar sounds like crisp!");
        }
    }
}
