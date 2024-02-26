using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyReflect
{
    class MyClass
    {
        private string myField = "私有字段";

        private static string sField = "静态私有字段";

        private string myProperty { get; set; } = "私有属性";

        private void FunA()
        {
            Console.WriteLine("私有方法执行。");
        }

        private static void FunB()
        {
            Console.WriteLine("静态私有方法执行。");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj=new MyClass();

            Type type = obj.GetType();
            BindingFlags flags = BindingFlags.Instance| BindingFlags.NonPublic;

            FieldInfo  fieldInfo = type.GetField("myField", flags);

            fieldInfo?.SetValue(obj, "ai");

            Console.WriteLine(fieldInfo?.GetValue(obj));

            PropertyInfo propertyInfo=type.GetProperty ("myProperty", flags);
            propertyInfo?.SetValue(obj, "新的私有属性");

            Console.WriteLine(propertyInfo?.GetValue(obj));

            MethodInfo method=type.GetMethod("FunA", flags);

            method?.Invoke(obj, null);

            flags = BindingFlags.Static | BindingFlags.NonPublic;
            fieldInfo = type.GetField("sField", flags);
            method = type.GetMethod("FunB", flags);

            method?.Invoke(obj, null);
            method?.Invoke(null, null);

        }
    }
}
