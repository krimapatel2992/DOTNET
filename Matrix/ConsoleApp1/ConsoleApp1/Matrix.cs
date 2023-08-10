using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Matrix<T>
    {
        private T[,] data;
        private int rows;
        private int columns;

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            data = new T[rows, columns];
        }

        public T this[int row, int col]
        {
            get { return data[row, col]; }
            set { data[row, col] = value; }
        }

        public int Rows
        {
            get { return rows; }
        }

        public int Columns
        {
            get { return columns; }
        }

        public void setData()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {

                    Console.WriteLine("Enter element [" + i + "][" + j + "]");
                    this[i, j] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                }
            }

        }
        public void getData()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    //Console.WriteLine("Enter element [" + i + "][" + j + "]");
                    Console.Write(this[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        public static Matrix<T> operator+ (Matrix<T> matrixa, Matrix<T> matrixb)
        {
            //if (matrixa.rows != matrixb.rows || matrixa.columns != matrixb.columns)
            //{
            //    throw new argumentexception("matrix dimensions must be the same for addition.");
            //}

            Matrix<T> result = new Matrix<T>(matrixa.rows, matrixa.columns);

            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.columns; j++)
                {
                    // perform addition of corresponding elements from both matrices
                    dynamic sum = (dynamic)matrixa[i, j] + matrixb[i, j];
                    result[i, j] = sum;
                }
            }

            return result;
        }
    


    public static Matrix<T> operator -(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            if (matrixA.Rows != matrixB.Rows || matrixA.Columns != matrixB.Columns)
            {
                throw new ArgumentException("Matrix dimensions must be the same for subtraction.");
            }

            Matrix<T> result = new Matrix<T>(matrixA.Rows, matrixA.Columns);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Columns; j++)
                {
                    // Perform subtraction of corresponding elements from both matrices
                    dynamic difference = (dynamic)matrixA[i, j] - matrixB[i, j];
                    result[i, j] = difference;
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            if (matrixA.Columns != matrixB.Rows)
            {
                throw new ArgumentException("Matrix dimensions are not valid for multiplication.");
            }

            Matrix<T> result = new Matrix<T>(matrixA.Rows, matrixB.Columns);

            for (int i = 0; i < matrixA.Rows; i++)
            {
                for (int j = 0; j < matrixB.Columns; j++)
                {
                    dynamic sum = 0;
                    for (int k = 0; k < matrixA.Columns; k++)
                    {
                        sum +=(dynamic) matrixA[i, k] * matrixB[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

    }


}
