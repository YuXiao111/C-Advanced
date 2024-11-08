using _001.泛型引入.Models;

namespace _001.泛型引入
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //没有泛型的情况
            //1.
            NoGenericClass noGenericClass = new NoGenericClass();

            Teacher teacher = new Teacher();
            string teaTypeName = noGenericClass.GetClassType(teacher);
            Console.WriteLine("类型名"+ teaTypeName );

            Student student = new Student();
            string stuTypeName=noGenericClass.GetClassType(student);
            Console.WriteLine("类型名"+stuTypeName );

            //2.
            int iVal = noGenericClass.GetIntValue("123");
            Console.WriteLine(iVal);
            float fVal=noGenericClass.GetFloatValue("123.000");
            Console.WriteLine(fVal);
            Console.ReadKey();
        }
    }
}