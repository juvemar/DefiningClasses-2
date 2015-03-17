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
            GenericList<int> listche = new GenericList<int>(4);

            listche.AddElement(5);
            listche.AddElement(6);
            listche.AddElement(7);
            listche.AddElement(8);
            listche.AddElement(9);

        }
    }
}
