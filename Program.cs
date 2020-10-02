using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch st = new StopWatch();
            int[] arr = new int[100];

            st.InputArray(ref arr);
            Console.WriteLine(st.Start());
            st.SortArray(ref arr);
            st.ShowArray(arr);

            Console.WriteLine(st.End());
            Console.WriteLine(st.GetElapsedTime());
        }
    }
}