using System;
using System.Threading.Tasks;
using System.Threading;

namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = MyMethod(12);
            Console.WriteLine("Hello World");
            Console.WriteLine(d.Result);
            
            Console.WriteLine("END");
            //Thread.Sleep(4000);
        }
        public static async Task<int> MyMethod(int myParameter)
        {
            //Thread.Sleep(4000);

            //Thread.Sleep in my button event handler (running in the UI thread), the UI is not responsive while it's sleeping.
            //https://stackoverflow.com/questions/13429707/how-to-get-awaitable-thread-sleep

            //http://hamidmosalla.com/2018/04/05/when-should-you-use-task-delay/
            await Task.Delay(2000);

            return 123;
            //await  123;
        }
    }
}
