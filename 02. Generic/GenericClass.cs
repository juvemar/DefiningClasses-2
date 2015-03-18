using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class GenericClass
    {
        static void Main()
        {
            GenericList<int> tester = new GenericList<int>(4);

            tester.AddElement(5);
            tester.AddElement(6);
            tester.AddElement(7);
            tester.AddElement(8);
            tester.AddElement(9);
            Console.WriteLine("New capacity is {0}",tester.Capacity);

            tester.Elements[1] = 3;
            Console.WriteLine("Index 1: " + tester.Elements[1]);

            Console.WriteLine("Index 2: " + tester.Elements[2]);
            tester.RemoveElement(2);
            Console.WriteLine("Index 2 after erasure: " + tester.Elements[2]);

            tester.InsertElement(1, 10);
            Console.WriteLine("Index 1 after inserting: " + tester.Elements[1]);
            Console.WriteLine("Index 2 after inserting: " + tester.Elements[2]);

            tester.ClearList();
            Console.WriteLine("Index 2 after clearing the list: " + tester.Elements[2]);

            int searchedElement = 5;
            if (tester.SearchFor(searchedElement) != -1)
            {
                Console.WriteLine("{0} is at position {1}", searchedElement, tester.SearchFor(searchedElement));
            }
            else
            {
                Console.WriteLine("There is no such element with value {0}", searchedElement);
            }
        }
    }
}
