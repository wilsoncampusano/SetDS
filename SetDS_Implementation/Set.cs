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
        private readonly int[] _elements ;
        private readonly int _collectionSize ;

        public Set(int capacity)
        {
            _collectionSize = capacity;    
            _elements = new int[capacity];
        }

        public void Add(int value)
        {
            if(!_elements.Any((e) =>  value == e  ))
                _elements[Capacity] = value;
                Capacity++;
        }

        public int Get()
        {
            return _elements[--Capacity];
        }
        
        public bool IsEmpty()
        {
            return Capacity != _collectionSize;
        }
    }
}
