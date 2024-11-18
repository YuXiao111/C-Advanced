using _002.泛型类.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.泛型类
{
    public class NoGenericClass
    {

        public string GetClassType(object obj)
        {
            return obj.GetType().Name;
        }

        public object GetObject(string str)
        {
            object obj = str;
            return obj;
        }

    }
}
