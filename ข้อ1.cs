using System;

public class MatrixOperations
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter '+' or '-' to perform matrix operations, or any other character to exit:");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operation == '+' || operation == '-')
            {
                Console.WriteLine("Enter the size of the matrix:");
                int size = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the elements of the matrix:");

                double[,] matrix = new double[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                double result = 0;

                if (operation == '+')
                {
                    result = SumMatrixElements(matrix, size);
                }
                else if (operation == '-')
                {
                    result = SubtractMatrixElements(matrix, size);
                }

                Console.WriteLine("Result: " + result);
                Console.WriteLine();
            }
            else
            {
                break;
            }
        }
    }

    // Function to calculate the sum of matrix elements
    public static double SumMatrixElements(double[,] matrix, int size)
    {
        double sum = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                sum += matrix[i, j];
            }
        }

        return sum;
    }

    // Function to calculate the subtraction of matrix elements
    public static double SubtractMatrixElements(double[,] matrix, int size)
    {
        double subtraction = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                subtraction -= matrix[i, j];
            }
        }

        return subtraction;
    }
}
