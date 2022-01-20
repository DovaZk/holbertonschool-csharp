using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double [,] rotationMatrix = new double[,] { {Math.Cos(angle), Math.Sin(angle)}, {Math.Sin(angle) * -1, Math.Cos(angle)}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (new double[,]{{-1}});

        double[,] results = new double[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                    results[i, j] = Math.Round(results[i, j] + matrix[i, k] * rotationMatrix[k, j], 2);
            }
        }
        return (results);
    }
}
