using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19._11._22
{
    internal class Team
    {
        public string Name { get; set; }
        public int Points = 0;
        public Team(string name)
        {
            Name = name;
        }
    }
}
