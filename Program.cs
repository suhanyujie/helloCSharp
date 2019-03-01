using System;
using System.Collections.Generic;
using myApp.BranchAndFor;
using myApp.String;
using myApp.List;

namespace myApp
{
    class Program
    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine($"Hello World!");
//            Console.WriteLine($"this current time is {DateTime.Now}!");
//        }

        static void Main()
        {
            //BranchAndFor.BranchAndFor.TestIf();
//            BranchAndFor.BranchAndFor.ExploreWhile();
//            BranchAndFor.BranchAndFor.ExploreFor();
//            String.ExplodeStr.TestStr();
//            String.ExplodeStr.ExplodeToString();
//            String.ExplodeStr.AequilatusStr();
//              List.FirstList.TestList();
//              List.FirstList.fibonacci();
              List.FirstList.fibonacci2();
        }

        static void NumberTest()
        {
            int a = 12;
            int b = 6;
            int c = a+b;
            int d = a + b - 12 * 17;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        static void maxNum()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine(min);
            Console.WriteLine($"the max value of int is:{max}");
            decimal f1 = Decimal.MinValue;
            decimal f2 = Decimal.MaxValue;
            Console.WriteLine($"the min decimal num is: {f1};\n the max decimal num is:{f2}");
        }

        static float getRectangleArea(float a,float b)
        {
            return a * b;
        }

        //计算圆面积
        static double getCircleArea(float r)
        {
            //单精度浮点数乘双精度浮点数  返回的是双精度浮点数
            return Math.PI * r * r;
        }
    }
}
