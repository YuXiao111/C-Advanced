using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.泛型类.GenericClasses
{
    //泛型类
    public class MyList<T>
    {
        List<T> list=new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }

        public void Delete(T item)
        {
            list.Remove(item);
        }
    }
}
