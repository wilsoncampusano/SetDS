using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetDS_Implementation
{
    public class Set
    {
        public int Capacity { get; private set; }
        private int element;
        private int _collectionSize=0;

        public Set(int capacity)
        {
            _collectionSize = capacity;
            
        }

        public void Add(int value)
        {
            element = value;
            Capacity++;
        }

        public int Get()
        {
            return element;
        }

        public bool IsEmpty()
        {
            return Capacity != _collectionSize;
        }
    }
}
