using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number of row : ");
            int row = int.Parse( Console.ReadLine());

            Console.WriteLine("Enter number of column : ");
            int col = int.Parse(Console.ReadLine());


            Matrix<int> intMatrix = new Matrix<int>(row, col);
            intMatrix.setData();


            Matrix<int> intMatrixA = new Matrix<int>(row, col);
            intMatrixA.setData();

            Console.WriteLine("sum Of the matrix");
            Console.WriteLine("--Matrix - 1 --");

            intMatrix.getData();
            Console.WriteLine("--Matrix - 2  --");

            intMatrixA.getData();

            Matrix<int> additionMatrix = new Matrix<int>(row, col);

            additionMatrix = intMatrix + intMatrixA;
            Console.WriteLine("-- ADDITION MATRIX --");

            additionMatrix.getData();

            Matrix<int> substractionMatrix = new Matrix<int>(row, col);

            substractionMatrix = intMatrix - intMatrixA;
            Console.WriteLine("-- SUBSTRACTION MATRIX --");

            substractionMatrix.getData();


            Matrix<int> multiplicationMatrix = new Matrix<int>(row, col);

            multiplicationMatrix = intMatrix * intMatrixA;
            Console.WriteLine("-- MULTIPLICATION MATRIX --");

            multiplicationMatrix.getData();

            //for (int i = 0; i < intMatrix.Rows; i++)
            //{
            //    for (int j = 0; j < intMatrix.Columns; j++)
            //    {   
            //        Console.WriteLine("Enter element ["+i+"]["+j+"]");
            //        intMatrix[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < intMatrix.Rows; i++)
            //{
            //    for (int j = 0; j < intMatrix.Columns; j++)
            //    {
            //        Console.WriteLine("Enter element [" + i + "][" + j + "]");
            //        Console.Write(intMatrix[i, j] + " ");
            //    }

            //}



            Console.ReadKey();
        }
    }
}
