using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class GenericList<T> where T : IComparable
    {
        const int constCapacity = 16;

        private T[] elements;
        private int capacity;
        private int counter = 0;

        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.elements = new T[capacity];
        }

        public GenericList()
            : this(constCapacity)
        {

        }

        public T[] Elements
        {
            get { return this.elements; }
            set { this.elements = value; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }

        public int Counter
        {
            get { return this.counter; }
        }

        public void AddElement(T element)
        {
            if (this.Counter >= this.Elements.Length)
            {
                this.Resize();
            }
           this.Elements[Counter] = element;
            counter++;
        }

        public T ShowElement(int index)
        {
            return this.Elements[index];
        }

        public void RemoveElement(int index)
        {

        }

        private void Resize()
        {
            int newCapacity = capacity * 2;
            T[] newData = new T[newCapacity];

            for (int i = 0; i < capacity; i++)
            {
                newData[i] = this.Elements[i];
            }

            this.Elements = newData;
            this.Capacity *= 2;
        }
    }
}
