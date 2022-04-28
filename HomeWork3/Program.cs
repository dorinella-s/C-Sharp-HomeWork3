using System.Collections.Generic;
using System;

namespace HomeWork3
{
    class Program
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */
            //your code here
            if (matrixOfIntegers.GetLength(0) == matrixOfIntegers.GetLength(1))
            {
                Console.WriteLine("The central element is " + matrixOfIntegers[matrixOfIntegers.GetLength(0) / 2, matrixOfIntegers.GetLength(1) / 2]);
            }
            else Console.WriteLine("This matrix doesn t have a central element");

            }
        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
            //your code here
            Console.WriteLine("The matrix is:");
            for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                {
                    Console.Write(matrixOfIntegers[i, j] + "     ");
                }
                Console.WriteLine();
            }

            int diagm = 0, diags = 0;
            if (matrixOfIntegers.GetLength(0) >= matrixOfIntegers.GetLength(1))
                {
            for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                {
                    // Condition for principal
                    // diagonal
                    if (i == j)
                        diagm += matrixOfIntegers[i, j];

                    // Condition for secondary
                    // diagonal
                    if ((i + j) == (matrixOfIntegers.GetLength(1) - 1))
                        diags += matrixOfIntegers[i, j];
                }
                
            }
            Console.WriteLine("First Diagonal:" + diagm);

            Console.WriteLine("Second Diagonal:" + diags);
                }
                else Console.WriteLine("This matrix doesn't have a diagonals");
        }
            public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            //your code here
            Console.WriteLine("\nThe star hight is " + triangleHight);

            int i, j;
            int aux = triangleHight;
            
            for (i = 0; i < triangleHight; i++)
            {
                for (j = 0; j < aux; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                aux--;
            }
        }
        public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            //your code here
            var sorted = new List<int>(listOfNumbers);
            sorted.Sort();
            Console.WriteLine(string.Join("  ", sorted));
        }
        public static void Main(String[] args)
        {
            Program homework = new Program();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };
            Console.WriteLine("Exercise 1 ----------------");
            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            Console.WriteLine("Exercise 2 ----------------");
            homework.GetSummOfDiagonalsElements(matrix);
            Console.WriteLine(".............................");
            homework.GetSummOfDiagonalsElements(matrix2);
            Console.WriteLine("Exercise 3 ----------------");
            homework.StarPrinter(3);
            Console.WriteLine("Exercise 4 ----------------");
            homework.SortList(list);
        }

    }
}
