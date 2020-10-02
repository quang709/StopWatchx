using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    class StopWatch
    {
        private DateTimeOffset startTime;
        private DateTimeOffset endTime;
        public StopWatch()
        {
            startTime = DateTime.Now;
        }
        public DateTimeOffset getStartTime() => this.startTime;
        public DateTimeOffset getEndTime() => this.endTime;

        public DateTimeOffset Start()
        {
            startTime = DateTimeOffset.Now;
            return startTime;
        }
        public DateTimeOffset End()
        {
            startTime = DateTimeOffset.Now;
            return startTime;
        }
        public int GetElapsedTime()
        {

            DateTimeOffset start = startTime;
            DateTimeOffset end = endTime;

            int result = -(end.Millisecond - start.Millisecond);

            return result;
        }
        public void InputArray(ref int[] arr)
        {
            var random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 1000);
            }
            Console.WriteLine(arr);
        }
        public void SortArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}