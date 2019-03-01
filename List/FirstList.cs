using System;
using System.Collections.Generic;

namespace myApp.List
{
    public class FirstList
    {
        public static void TestList()
        {
            var names = new List<string>
            {
                "<name>","Ana","Felipe",
            };
            //修改List中的数据
            names[0] = "samuel";
            foreach (var name in names)
            {
                Console.WriteLine($"this is {name}");
            }
            // 列表的查询
            int index = names.IndexOf("Felipe");
            Console.WriteLine($"Felipe 对应的索引位置是：{index}");
            names.Add("Mark");
            Console.WriteLine("新增了成员Mark");
            names.Remove("Ana");
            Console.WriteLine("移除了成员 Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"this is {name}");
            }
        }

        public static void fibonacci()
        {
            var fibonacciNumbers = new List<int>(){1,1};
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach(var item in fibonacciNumbers)
                Console.WriteLine(item);
        }

        public static void fibonacci2(int paramNum=20)
        {

            var fibonacciNumbers = new List<int>(){0,1};
            int i=0;
            int nextNum=0;
            while (true)
            {
                nextNum = fibonacciNumbers[i] + fibonacciNumbers[i+1];
                if (fibonacciNumbers.Count>paramNum)
                {
                    break;
                }
                else
                {
                    fibonacciNumbers.Add((int)nextNum);
                }
                i++;
            }

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}