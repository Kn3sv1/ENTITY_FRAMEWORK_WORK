using System;
using System.Threading.Tasks;
using System.Threading;

namespace TaskDemo
{
    public class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("ManagedThreadId MAIN BEGIN:" + Thread.CurrentThread.ManagedThreadId);
            var d = MyMethod(12);
            Console.WriteLine("Hello World");
            Console.WriteLine(d.Result);
            
            Console.WriteLine("END");
            Console.WriteLine("ManagedThreadId MAIN END:" + Thread.CurrentThread.ManagedThreadId);
            //Thread.Sleep(4000);
        }
        public static async Task<int> MyMethod(int myParameter)
        {
            Console.WriteLine("ManagedThreadId BEGIN:" + Thread.CurrentThread.ManagedThreadId);
            //Thread.Sleep(4000);

            //Thread.Sleep in my button event handler (running in the UI thread), the UI is not responsive while it's sleeping.
            //https://stackoverflow.com/questions/13429707/how-to-get-awaitable-thread-sleep

            //http://hamidmosalla.com/2018/04/05/when-should-you-use-task-delay/
            DateTime _start = DateTime.Now;
            await Task.Delay(4000);

            await MyLoveAsync();
            TimeSpan elapsed = DateTime.Now - _start;
            Console.WriteLine("Operation time was: " + elapsed.Minutes + "mn " + elapsed.Seconds + "s");
            Console.WriteLine("ManagedThreadId AFTER:" + Thread.CurrentThread.ManagedThreadId);

            return 123;
            //await  123;
        }

        public async static Task<int> MyLoveAsync()
        {
            Thread.Sleep(4000);

            return 11111;
        }
    }
}
