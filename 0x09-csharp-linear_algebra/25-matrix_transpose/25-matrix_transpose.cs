using System;

class MatrixMath
{
    /// <summary>
    /// A function to transpose a matrix
    /// </summary>
    /// <param name="matrix">Matrix of doubles</param>
    /// <returns>An empty matrix on fail, or a new matrix</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return (new double[,]{});

        double[,] results = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                results[j, i] = matrix[i, j];
            }
        }
        return (results);
    }
}
