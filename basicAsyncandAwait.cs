using System;
using System.Threading.Tasks;

namespace AsyncandAwaitProject
{
    class basicAsyncandAwait
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }
        public static async void Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("i'm watching movie");
                }
            });
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("My brother Reading news paper");
            }
        }
    }
}
