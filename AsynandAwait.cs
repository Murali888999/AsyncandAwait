using System;
using System.Threading.Tasks;

namespace AsyncandAwaitProject
{
    class AsynandAwait
    {
        static void Main(string[] args)
        {
            test();
            Console.Read();
        }
        public static async void test()
        {
            Task<int> task = work1();
            work2();
            int count = await task;
            exams(count);
        }
        public static async Task<int> work1()
        {
            int attempts = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("writing exam :");
                    attempts += 1;
                }
            });
            return attempts;
        }
        public static void work2()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("watching movie");
            }
        }
        public static void exams(int count)
        {
            Console.WriteLine("no of exams :" + count);
        }
    }
}

