using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace 特性
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple = true,Inherited = true)]
    class CustomAttribute:Attribute
    {
        public CustomAttribute()
        {
            
        }

        public CustomAttribute(int i) { }

        public string name { get; set; }

        public int count;
    }

    [CustomAttribute(name = "string")]
    class UserClass
    {
        
    }
}
