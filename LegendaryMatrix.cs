using System;
namespace LegendaryMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input '+' or '-' (any other character to exit): ");
                char matrixOperation = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (matrixOperation != '+' && matrixOperation != '-')
                {
                    break;
                }
                Console.Write("Input the dimensions of the matrix: ");
                int dimension = int.Parse(Console.ReadLine());
                double[,] inputMatrix = new double[dimension, dimension];
                Console.WriteLine("Input  elements of the matrix:");
                for (int row = 0; row < dimension; row++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
                        inputMatrix[row, col] = double.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Resulting matrix:");
                for (int row = 0; row < dimension; row++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
                        if (matrixOperation == '+')
                        {
                            Console.Write(Math.Abs(inputMatrix[row, col]) + " ");
                        }
                        else
                        {
                            Console.Write(-inputMatrix[row, col] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}