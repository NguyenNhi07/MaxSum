using System;
namespace MaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 1 };
            int[] sumArray = Sum(Array);
            int maxSum = MaxSum(sumArray);
            Console.Write("Tổng giá trị lớn nhất là: " + maxSum);
        }
        static int[] Sum(int[] Array)
        {
            int[] sumArray = new int[Array.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < Array.Length; j += 2)
                {
                    sum += Array[j];
                }
                sumArray[i] = sum;
            }
            return sumArray;
        }
        static int MaxSum(int[] sumArray)
        {
            int maxSum = 0;
            int tempSum = 0;
            foreach (int num in sumArray)
            {
                tempSum = Math.Max(num, tempSum);
                maxSum = Math.Max(maxSum, tempSum);
            }
            return maxSum;
        }
    }
}