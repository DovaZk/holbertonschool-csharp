using System;

class VectorMath
{
    /// <summary>
    /// Function that accepts two 3D vectors to produce a cross product
    /// </summary>
    /// <param name="vector1">First 3D vector</param>
    /// <param name="vector2">Second 3D vector</param>
    /// <returns>-1 on an error, or the resulting cross product</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
            return (new double[]{-1});

        double[] result = new double[3];

        result[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
        result[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
        result[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);

        return (result);
    }
}
