using System;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = MyMethod(12);
            //Console.WriteLine("Hello World");
            Console.WriteLine(d.Result);
            
            //Console.WriteLine(111);
        }
        public static async Task<int> MyMethod(int myParameter)
        {
            return 123;
        }
    }
}
