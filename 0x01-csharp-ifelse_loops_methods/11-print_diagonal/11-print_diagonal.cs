using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int i, j;
        if (length <= 0) {
            Console.Write("\n");
        }
        else {
            for (i = 1; i <= length; i++) {
                
                for (j = 0; j < i; j++) {
                    Console.Write(" ");   
                } 
                Console.WriteLine("\\");   
            }
            Console.WriteLine("");
        }
    }
}
