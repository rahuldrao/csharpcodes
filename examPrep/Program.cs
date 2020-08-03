using System;
using System.Collections.Generic;

public class QuadraticEquation
{
    static int minimumbox(int []arr, int n)
    {
        Queue<int> q = new Queue<int>();

        Array.Sort(arr);
        int a;
        q.Enqueue(arr[0]);
        for(int i=0;i<n;i++)
        {
            a = q.Peek();
            if(arr[i]>(2*a))
            {
                q.Dequeue();
                q.Enqueue(arr[i]);
            }
        }

        return q.Count;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 4, 1, 2, 8 };
        int n = arr.Length;

        Console.WriteLine(minimumbox(arr, n));
    }
}