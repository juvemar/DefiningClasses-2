using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Matrix
{
    class MatrixMain
    {
        static void Main()
        {
            Matrix<double> first = new Matrix<double>(2, 2);
            //initializing the matrix:
            first[0, 0] = 1;
            first[0, 1] = 3;
            first[1, 0] = 2;
            first[1, 1] = 4;

            for (int row = 0; row < first.Rows; row++)//printing the matrix
            {
                for (int col = 0; col < first.Cols; col++)
                {
                    Console.WriteLine("On row {0} col {1} is {2}.", row, col, first[row, col]);
                }
            }

            first[0, 1] = 3;//changing a particular element
            Console.WriteLine("The number on row {0} col {1} was changed to {2}.", 0, 1, first[0, 1]);

            Matrix<double> second = new Matrix<double>(2, 2);
            second[0, 0] = -2;
            second[0, 1] = 1;
            second[1, 0] = 0;
            second[1, 1] = 2;

            Matrix<double> added = first + second;//testing + operator
            Console.WriteLine("The new matrix after the addition:");
            for (int row = 0; row < added.Rows; row++)
            {
                for (int col = 0; col < added.Cols; col++)
                {
                    Console.Write("{0,-10}",added[row,col]);
                }
                Console.WriteLine();
            }

            Matrix<double> subtracted = first - second;//testing - operator
            Console.WriteLine("The new matrix after the subtraction:");
            for (int row = 0; row < subtracted.Rows; row++)
            {
                for (int col = 0; col < subtracted.Cols; col++)
                {
                    Console.Write("{0,-10}", subtracted[row, col]);
                }
                Console.WriteLine();
            }

            Matrix<double> multiplied = first * second;//testing * operator
            Console.WriteLine("The new matrix after the multiplication:");
            for (int row = 0; row < multiplied.Rows; row++)
            {
                for (int col = 0; col < multiplied.Cols; col++)
                {
                    Console.Write("{0,-10}", multiplied[row, col]);
                }
                Console.WriteLine();
            }

            if (first)//testing true operator
            {
                Console.WriteLine("The matrix has no zero elements!");
            }
            else
            {
                Console.WriteLine("The matrix has at least 1 zero element!");
            }

            first[1, 1] = 0;

            if (first)//testing false operator
            {
                Console.WriteLine("The matrix has no zero elements!");
            }
            else
            {
                Console.WriteLine("The matrix has at least 1 zero element!");
            }

        }
    }
}
