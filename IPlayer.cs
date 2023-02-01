using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest5
{
    internal interface IPlayer
    {
        string Name { get; set; }
        int Age { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        int Stamina { get; set; }
        int Speed { get; set; }
        int Power { get; set; }

        void GetInfo();
    }
}
