using System;
using System.Collections.Generic;

namespace myApp.String
{
    public class ExplodeStr
    {
        public static void TestStr()
        {
            var name="<name >";
            Console.WriteLine($"hello~,{name}");

        }

        public static void ExplodeToString()
        {
            var item = new Vegetable("eggplant");
            Console.WriteLine($"the price of {item}");
        }

        // 等宽字符显示
        public static void AequilatusStr()
        {
            var titles = new Dictionary<string, string>()
            {
                ["Doyle,arthur Conan"] = "Hound of NBasker,The",
                ["London,Jack"] = "Call of the Wild,The",
                ["Shakespeare,William"] = "Tempest,The",
            };
            foreach (var item in titles)
            {
                Console.WriteLine($"|{item.Key,-25}|{item.Value,30}|");
            }
        }
    }

    public class Vegetable
    {
        public Vegetable(string name) => Name = name;
        public string Name { get; }

        public override string ToString() => Name;
    }

}