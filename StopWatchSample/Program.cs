using System.Diagnostics;

namespace StopWatchSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(5000);
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
        }
    }
}