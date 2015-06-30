using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetDS_Implementation
{
    public class Set
    {
        public int Capacity { get; private set; }

        public Set(int capacity)
        {
            Capacity = capacity;
        }
    }
}
