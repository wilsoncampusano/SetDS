using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetDS_Implementation
{
    public class Set
    {
        public int Capacity { get; private set; }
        private int element1;
        private int element2;
        private int _collectionSize=0;

        public Set(int capacity)
        {
            _collectionSize = capacity;    
        }

        public void Add(int value)
        {
            if (element1 == 0)
                element1 = value;
            else if(element2== 0)
                element2 = value;
            Capacity++;
        }

        public int Get()
        {
            var toReturn = -1;
            if (element1 != 0)
            {
                toReturn = element1;
                element1 = 0;
            }
            else if(element2 != 0)
            {
                toReturn = element2;
                element2 = 0;
            }
            return toReturn;
        }
        
        public bool IsEmpty()
        {
            return Capacity != _collectionSize;
        }
    }
}
