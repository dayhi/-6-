using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //检测为true是否会在初始化后暂停
            ManualResetEvent mre=new ManualResetEvent(true);

            mre.Reset();

            Task.Run(() =>
            {
                Console.WriteLine("这是另外一个线程{0}", Task.CurrentId);
                Console.WriteLine("开始等待{0}", Task.CurrentId);
                mre.WaitOne();
                Console.WriteLine("等待结束{0}", Task.CurrentId);
            });

            Task.Run(() =>
            {
                Console.WriteLine("这是另外一个线程{0}", Task.CurrentId);
                Console.WriteLine("开始等待{0}", Task.CurrentId);
                mre.WaitOne();
                Console.WriteLine("等待结束{0}", Task.CurrentId);
            });

            Thread.Sleep(1000 * 3);
            mre.Set();
            Console.WriteLine("结束");

            Console.ReadKey();
        }
    }
}
