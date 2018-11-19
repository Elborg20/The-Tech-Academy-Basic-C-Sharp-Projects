using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdditionalFeatures
{
    class Construct
    {
        public Construct (string name) : this(name, 100)
        {
        }
        public Construct (string name, int money)
        {
            Name = name;
            Money = money;
        }
        public string Name { get; set; }
        public int Money { get; set; }
    }
}
