using System;
using System.Collections.Generic;

namespace C__Projects
{ 
    class Program
    {
         static void Main(string[] args)
         {
             int n = int.Parse(Console.ReadLine());
             int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            int max = A[0];
            int min = A[0];
            int idxMax = 0;
            int idxMin = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (Math.Abs(max) < Math.Abs(A[i]))
                {
                    max = A[i];
                    idxMax = i;
                }
                if (Math.Abs(min) > Math.Abs(A[i]))
                {
                    min = A[i];
                    idxMin = i;
                }

            }
            double result = 1;
            if (idxMax > idxMin)
            {
                for (int i = idxMin; i < idxMax; i++)
                {
                    result *= A[i];
                }
            }
            else
            {
                for (int i = idxMax; i < idxMin; i++)
                {
                    result *= A[i];
                }
            }
            Console.WriteLine(result);

        }

    }
}