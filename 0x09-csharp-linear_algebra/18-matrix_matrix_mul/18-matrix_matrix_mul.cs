using System;

class MatrixMath
{
    /// <summary>
    /// Multiply two matrixes together
    /// </summary>
    /// <param name="matrix1">First matrix to multiple</param>
    /// <param name="matrix2">Second matrix to multiply</param>
    /// <returns>-1 on error, or the resulting matrix from te multiplication</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int m1_y = matrix1.GetLength(0);
        int m1_x = matrix1.GetLength(1);
        int m2_y = matrix2.GetLength(0);
        int m2_x = matrix2.GetLength(1);

        if (m1_x != m2_y)
            return (new double[,]{{-1}});

        double[,] results = new double[m1_y, m2_x];
        for (int i = 0; i < m1_y; i++)
        {
            for (int j = 0; j < m2_x; j++)
            {
                results[i, j] = 0;
                for (int k = 0; k < m1_x; k++)
                {
                    results[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return (results);
    }
}
