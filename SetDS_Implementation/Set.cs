using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace SetDS_Implementation
{
    public class Set
    {
        public int Capacity { get; private set; }
        private int[] elements ;

        private int _collectionSize=0;

        public Set(int capacity)
        {
            _collectionSize = capacity;    
            elements = new int[capacity];
        }

        public void Add(int value)
        {
            if (elements.Any(element => element  == value))
                return;

            elements[Capacity] = value;
            Capacity++;
        }

        public int Get()
        {
            if (Capacity < 0)
                return -1;

            return elements[--Capacity];

        }
        
        public bool IsEmpty()
        {
            return Capacity != _collectionSize;
        }
    }
}
