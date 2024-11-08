using _001.泛型引入.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.泛型引入
{
    public class NoGenericClass
    {
        public string GetClassType(Teacher teacher)
        {
            return teacher.GetType().Name;
        }

        public string GetClassType(Student student)
        {
            return student.GetType().Name;
        }

        public string GetClassType(Worker worker)
        {
            return worker.GetType().Name;
        }

        public int GetIntValue(string str)
        {
            return int.Parse(str);
        }
        public float GetFloatValue(string str)
        {
            return float.Parse(str);
        }

    }
}
