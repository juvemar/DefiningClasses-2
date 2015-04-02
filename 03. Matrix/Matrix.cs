using System;

namespace _03.Matrix
{
    class Matrix<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
            set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Rows are out of range!");
                }
                else
                {
                    this.Rows = value;
                }
            }
        }
        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
            set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Collumns are out of range!");
                }
                else
                {
                    this.Rows = value;
                }
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row > this.Rows)
                {
                    throw new ArgumentOutOfRangeException("Row is out of range!");
                }
                else
                {
                    return this.matrix[row, col];
                }
            }
            set
            {
                if (col < 0 || col > this.Cols)
                {
                    throw new ArgumentOutOfRangeException("Collumn is out of range!");
                }
                else
                {
                    this.matrix[row, col] = value;
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArithmeticException("Matrices with different sizes cannot be added or subtracted!");
            }
            else
            {
                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Cols; j++)
                    {
                        result[i, j] = (dynamic)first[i, j] + second[i, j];
                    }
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArithmeticException("Matrices with different sizes cannot be added or subtracted!");
            }
            else
            {
                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Cols; j++)
                    {
                        result[i, j] = (dynamic)first[i, j] - second[i, j];
                    }
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            var result = new Matrix<T>(first.Rows, first.Cols);

            if (first.Rows != second.Cols && first.Cols != second.Rows)
            {
                throw new ArithmeticException("Rows of the first matrix and collumns of the second matrix must be equal!");
            }
            else
            {
                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Cols; j++)
                    {
                        for (int k = 0; k < first.Cols; k++)
                        {
                            result[i, j] += (dynamic)first[i, k] * second[k, j];
                        }
                    }
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool result = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Rows; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool result = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Rows; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
