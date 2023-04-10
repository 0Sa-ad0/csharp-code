using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();
        int len1 = str1.Length;
        int len2 = str2.Length;

        int[,] arr = new int[len1 + 1, len2 + 1];

        for (int i = 0; i <= len1; i++)
        {
            for (int j = 0; j <= len2; j++)
            {
                if (i == 0 || j == 0)
                {
                    arr[i, j] = 0;
                }
                else if (str1[i - 1] == str2[j - 1])
                {
                    arr[i, j] = arr[i - 1, j - 1] + 1;
                }
                else
                {
                    arr[i, j] = Math.Max(arr[i - 1, j], arr[i, j - 1]);
                }
            }
        }

        int index = arr[len1, len2];
        char[] lcs = new char[index];

        int m = len1, n = len2;
        while (m > 0 && n > 0)
        {
            if (str1[m - 1] == str2[n - 1])
            {
                lcs[index - 1] = str1[m - 1];
                m--;
                n--;
                index--;
            }
            else if (arr[m - 1, n] > arr[m, n - 1])
            {
                m--;
            }
            else
            {
                n--;
            }
        }

        Console.WriteLine("The Longest Common Subsequence is: " + new string(lcs));
    }
}
