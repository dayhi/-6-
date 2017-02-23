using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 特性
{
    class Program
    {
        static void Main(string[] args)
        {
            UserClass custom=new UserClass();
            object[] obj = custom.GetType().GetCustomAttributes(true);
            Console.WriteLine((obj[0] as CustomAttribute).name);
            

            Console.ReadKey();
        }
    }
}
