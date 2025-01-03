using System;
using System.Threading;

namespace DateTimeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime;
            while (true)
            {
                dateTime = DateTime.Now;
                Console.Write(dateTime.ToString("HH:mm:ss"));
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}