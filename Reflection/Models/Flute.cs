using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Models
{
    internal class Flute : Instrument
    {
        public int Holes { get; set; }
        public string Color { get; set; }
        public override void Sound()
        {
            Console.WriteLine("Flute sounds like whistle!");
        }
    }
}
