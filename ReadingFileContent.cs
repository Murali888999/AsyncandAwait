using System;
using System.Threading.Tasks;
using System.IO;
namespace AsyncandAwaitProject
{
    class ReadingFileContent
    {
        static void Main(string[] args)
        {
            Task task = new Task(test);
            task.Start();
            task.Wait();
            Console.Read();
        }
        static  async void  test()
        {
            string path = "e:\\mohan.txt";
            Task<int> task = Readfile(path);

            Console.WriteLine("watching video.....");
            Console.WriteLine("chatting with friends");

            int i = await task;
            TotalChars(i);           
        }
        static  async Task<int> Readfile(string s)
        {
            int length = 0;
            Console.WriteLine("File Reading.........\n" +"......................\n"+"................\n");
            using (StreamReader sr = new StreamReader(s))
            {
                string s1 = await sr.ReadToEndAsync();
                length = s1.Length;
            }
            return length;
        } 
        static void TotalChars(int c)
        {
            Console.WriteLine("total no.of chars:" + c);
        }
    }
}