using System;

namespace Day05
{
    public class jiecheng
    {
        public static void Main()
        {
            string[] str = {"aa", "333", "ccc"};
            string seperator = "|";
            Console.WriteLine(Join(str,"|"));
        }

        public static string Join(string[] strs,string seperator)
        {
            string a="";
            for (int i = 0; i < strs.Length; i++)
            {
                a = a + strs[i] + (strs.Length-1==i?"":seperator);
            }
            return a;
        }
    }
}