using System;

class MatrixMath
{
    /// <summary>
    /// Function to calculate the Determinate of 2D and 3D matrixes
    /// </summary>
    /// <param name="matrix">A matrix of doubles</param>
    /// <returns>-1 on error, or the determinant</returns>
    public static double Determinant(double[,] matrix)
    {
        double det = 0;

        if (matrix.GetLength(1) > 3 || matrix.GetLength(1) < 2)
            return (-1);

        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
            return (-1);

        if (matrix.GetLength(0) != matrix.GetLength(1))
            return (-1);

        if (matrix.GetLength(0) == 3)
        {
            //for (int i = 0; i < 3 ; i++)
            // det = det + (matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]));

            double det_1 = (matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]);
            double det_2 = (matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]);
            double det_3 = (matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]);

            det = (matrix[0, 0] * det_1) - (matrix[0, 1] * det_2) + (matrix[0, 2] * det_3);

        }

        if (matrix.GetLength(0) == 2)
        {
            det = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        }
        return (Math.Round(det, 2));
    }
}
