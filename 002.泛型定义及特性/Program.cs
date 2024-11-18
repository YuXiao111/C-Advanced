using _002.泛型方法.GenericClasses;
using _002.泛型方法.Models;

namespace _002.泛型方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //没有泛型的情况
            //1.
            NoGenericClass noGenericClass = new NoGenericClass();
            Teacher teacher = new Teacher();
            //string teaTypeName = noGenericClass.GetClassType(teacher);
            //Console.WriteLine("类型名"+ teaTypeName );

            Student student = new Student();
            //string stuTypeName=noGenericClass.GetClassType(student);
            //Console.WriteLine("类型名"+stuTypeName );

            double Num = 2.5;
            //string douTypeName=noGenericClass.GetClassType(Num);//double->object装箱
            //Console.WriteLine("类型名" + douTypeName);

            ////2.
            //int iVal =Convert.ToInt32( noGenericClass.GetObject("123"));//object->int拆箱
            //Console.WriteLine(iVal);
            //float fVal = float.Parse((string)noGenericClass.GetObject("123.000"));
            //Console.WriteLine(fVal);

            string teaTypeName = GenericMethodClass.GetClassType<Teacher>(teacher);
            string stuTypeName = GenericMethodClass.GetClassType(student);//自动推算实际类型
            string douTypeName = GenericMethodClass.GetClassType(Num);

            Console.WriteLine(teaTypeName+stuTypeName+douTypeName);
            Console.ReadKey();
        }
    }
}