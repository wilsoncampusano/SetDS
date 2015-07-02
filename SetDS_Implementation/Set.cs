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
        private readonly IConvertible[] _elements ;
        private readonly int _collectionSize ;

        public Set(int capacity)
        {
            _collectionSize = capacity;    
            _elements = new IConvertible[capacity];
        }

        public void Add(IConvertible value)
        {
            if(!_elements.Any( value.Equals ))
                _elements[Capacity] = value;
                Capacity++;
        }

        public IConvertible Get()
        {
            return _elements[--Capacity];
        }
        
        public bool IsEmpty()
        {
            return Capacity != _collectionSize;
        }
    }
}
