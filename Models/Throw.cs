using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandCricket.Models
{
    public class Throw
    {
        public Throw(int total)
        {
            TotalThrows = total;
        }
        public int TotalThrows { get; set; }
        public int CurrentThrow { get; set; }
    }
}
