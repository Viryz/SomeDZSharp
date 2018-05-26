using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class MyMatrix
    {
        int[][] array;

        public MyMatrix(int rows, int cols)
        {
            array = new int[rows][];
            for (int i = 0; i < cols; i++)
                array[i] = new int[cols];
        }

        public int this[int row, int col]
        {
            get
            {
                return array[row][col];
            }
            set
            {
                array[row][col] = value;
            }
        }

        public void AddNewRow(int[] row)
        {
            if (row.Length != array.GetLength(0))
                throw new Exception("Range of array not equal range of matrix row");
            int[][] newArray = new int[array.Length + 1][];
            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i];
            newArray[array.Length] = row;
            array = newArray;
        }

        public void AddNewCol(int[] col)
        {
            if (col.Length != array.Length)
                throw new Exception("Range of array not equal range of matrix col");
            int[][] newArray = new int[array.Length][];
            int rowLength = array[0].Length;
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = new int[rowLength + 1];
                for (int j = 0; j < array[i].Length; j++)
                    newArray[i][j] = array[i][j];
                newArray[i][rowLength] = col[i];
            }
            array = newArray;
        }

        public void Display()
        {
            Console.WriteLine("Matrix: ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write("{0}\t", array[i][j]);
                Console.WriteLine();
            }
        }

        public void RandomInit()
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array[i].Length; j++)
                    array[i][j] = r.Next(10, 99);
        }

    }
}
