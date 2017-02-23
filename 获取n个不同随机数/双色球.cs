using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 获取n个不同随机数
{
    class 双色球
    {
        public static readonly object objLock = new object();
        public static List<int> ints = new List<int>();

        public static void ShowToWindows(int i)
        {
            lock (objLock)
            {
                //数组中有则返回
                foreach (var value in ints)
                {
                    if (value == i)
                        return;
                }

                ints.Add(i);

                if (ints.Count == 6)
                {
                    //输出到屏幕
                    

                    ints.Clear();
                }
            }
        }
    }
}
