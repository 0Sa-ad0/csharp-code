using System;

public class MatrixChainOrder
{
    public static void Main()
    {
        // Input matrix dimensions
        int[] d = {5, 10, 3, 12, 5, 50, 6};
        int n = d.Length - 1;

        // Initialize M and s matrices
        int[,] M = new int[n+1, n+1];
        int[,] s = new int[n+1, n+1];

        // Initialize diagonal of M matrix to 0
        for (int i = 1; i <= n; i++)
        {
            M[i, i] = 0;
        }

        // Calculate M and s matrices
        for (int len = 2; len <= n; len++)
        {
            for (int i = 1; i <= n-len+1; i++)
            {
                int j = i + len - 1;
                M[i, j] = int.MaxValue;
                for (int k = i; k < j; k++)
                {
                    int q = M[i, k] + M[k+1, j] + d[i-1] * d[k] * d[j];
                    if (q < M[i, j])
                    {
                        M[i, j] = q;
                        s[i, j] = k;
                    }
                }
            }
        }

        // Print minimum cost and optimal ordering of matrix multiplication
        Console.WriteLine("Minimum cost of multiplying the matrices: " + M[1, n]);
        Console.WriteLine("Optimal ordering of matrix multiplication:");
        PrintOptimalOrder(s, 1, n);
    }

    // Recursive function to print optimal ordering of matrix multiplication
    private static void PrintOptimalOrder(int[,] s, int i, int j)
    {
        if (i == j)
        {
            Console.Write("A" + i);
        }
        else
        {
            Console.Write("(");
            PrintOptimalOrder(s, i, s[i, j]);
            PrintOptimalOrder(s, s[i, j]+1, j);
            Console.Write(")");
        }
    }
}
