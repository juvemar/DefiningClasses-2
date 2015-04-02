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
            if (this.Counter == this.Elements.Length)
            {
                this.AutoGrow();
            }

            this.Elements[Counter] = element;
            this.counter++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > Elements.Length - 1)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range!");
                }
                return this.Elements[index];
            }
            set
            {
                if (index < 0 || index > Elements.Length - 1)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range!");
                }
                this.Elements[index] = value;
            }
        }

        public void RemoveElement(int index)
        {
            if (index < 0 || index > Elements.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Index is out of range!");
            }

            T[] newList = new T[capacity];
            for (int i = 0; i < index; i++)
            {
                newList[i] = this.Elements[i];
            }
            for (int i = index; i < this.Elements.Length - 1; i++)
            {
                newList[i] = this.Elements[i + 1];
            }

            this.Elements = newList;
            this.counter--;
        }

        public void InsertElement(int index, T element)
        {
            if (index < 0 || index > Elements.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Index is out of range!");
            }

            if (this.Counter == this.Elements.Length)
            {
                this.AutoGrow();
            }

            T[] newList = new T[capacity];
            for (int i = 0; i < index; i++)
            {
                newList[i] = this.Elements[i];
            }
            newList[index] = element;
            for (int i = index + 1; i < this.Elements.Length; i++)
            {
                newList[i] = this.Elements[i - 1];
            }

            this.Elements = newList;
            this.counter++;
        }

        public void ClearList()
        {
            this.Elements = new T[capacity];
            this.counter = 0;
        }

        public int SearchFor(T element)
        {
            for (int i = 0; i < this.Elements.Length; i++)
            {
                if (this.Elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < this.Elements.Length; i++)
            {
                builder.AppendFormat("On position {0} is {1}", i, this.Elements[i]);
                builder.AppendLine();
            }

            return builder.ToString();
        }

        public T Max()
        {
            T max = this.Elements[0];

            for (int i = 1; i < this.Elements.Length; i++)
            {
                if (max.CompareTo(this.Elements[i]) < 0)
                {
                    max = this.Elements[i];
                }
            }

            return max;
        }

        public T Min()
        {
            T min = this.Elements[0];

            for (int i = 1; i < this.Elements.Length; i++)
            {
                if (min.CompareTo(this.Elements[i]) > 0)
                {
                    min = this.Elements[i];
                }
            }

            return min;
        }

        private void AutoGrow()
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
