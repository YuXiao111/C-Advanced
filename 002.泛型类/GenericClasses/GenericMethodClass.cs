using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.泛型类.GenericClasses
{
    public class GenericMethodClass
    {
        //T类型占位符，传入的类型不确定，调用时，用实际类型代替传入的类型
        //泛型方法：方法名<T>
        public static string GetClassType<T>(T obj)
        {
            return obj.GetType().Name;
        }
    }
}
