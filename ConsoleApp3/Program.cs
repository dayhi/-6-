using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1

            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            ////主线程接入其中一个的计算，会卡住线程
            //Parallel.Invoke(() => Console.WriteLine("hello1,{0}", Thread.CurrentThread.ManagedThreadId),
            //    () => Console.WriteLine("hello2,{0}", Thread.CurrentThread.ManagedThreadId),
            //    () => Console.WriteLine("hello3,{0}", Thread.CurrentThread.ManagedThreadId),
            //    () => Console.WriteLine("hello4,{0}", Thread.CurrentThread.ManagedThreadId),
            //    () => Console.WriteLine("hello5,{0}", Thread.CurrentThread.ManagedThreadId));
            //Console.WriteLine($"out{Thread.CurrentThread.ManagedThreadId}");

            //Parallel.For(0, 5, i => Console.WriteLine("hello{1},{0}", Thread.CurrentThread.ManagedThreadId, i));

            //Parallel.ForEach(new int[] { 34, 23, 54, 76 }, i => Console.WriteLine("hello2{1},{0}", Thread.CurrentThread.ManagedThreadId, i));

            ////new ParallelOptions(){MaxDegreeOfParallelism = 5}设置此任务最大线程数
            //Parallel.For(0, 5, new ParallelOptions() { MaxDegreeOfParallelism = 5 }, i => Console.WriteLine("hello{1},{0}", Thread.CurrentThread.ManagedThreadId, i));

            #endregion

            #region 2

            for (int i = 0; i < 5; i++)
            {
                new Action(() =>
                {
                    Console.WriteLine(i);
                }).BeginInvoke(null,null);
            }

            #endregion


            Console.ReadKey();
        }
    }
}
