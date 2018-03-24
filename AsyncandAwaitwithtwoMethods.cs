using System;
using System.Threading.Tasks;

namespace AsyncandAwaitProject
{
    class AsyncandAwaitwithtwoMethods
    {
        static void Main(string[] args)
        {
            callmethod();
            Console.ReadKey();
        }
        public static async void  callmethod()
        {
            Task<int> task = Method1();
            Method2();
            int count = await task;
            Method3(count);
        }
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
                {
                for(int i=0;i<50;i++)
                {
                    Console.WriteLine("Method1");
                        count += 1;
                }
            });
            return count;
        }
        public static void Method2()
        {
            for(int i =0;i<15;i++)
            {
                Console.WriteLine("Method2");
            }
        }
        public static void  Method3(int count)
        {
            Console.WriteLine("count is:" + count);
        }
    }
}
