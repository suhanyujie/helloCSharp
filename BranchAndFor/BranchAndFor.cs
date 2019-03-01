using System;

namespace myApp.BranchAndFor
{
    public class BranchAndFor
    {
        public static void TestIf()
        {
            int a=19, b=10;
            if (a+b>20)
            {
                Console.WriteLine("it is bigger than 20");
            }
        }

        public static void ExploreWhile()
        {
            int a = 4;
            while (a>0)
            {
                Console.WriteLine($"this is times for {a}");
                a--;
            }
        }

        public static void ExploreFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"This is time of :{i}");
            }
        }
    }
}