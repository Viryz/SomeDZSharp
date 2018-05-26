using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix m = new MyMatrix(5, 5);
            m.RandomInit();
            m.Display();

            int[] row = new int[5] { 0, 0, 0, 0, 0 };
            int[] col = new int[6] { 0, 0, 0, 0, 0 , 0};

            m.AddNewRow(row);
            m.Display();

            m.AddNewCol(col);
            m.Display();

            Console.ReadLine();
        }
    }
}
