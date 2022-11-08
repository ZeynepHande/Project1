using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Inputs
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Inputs()
        {
        }

        public Inputs(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
