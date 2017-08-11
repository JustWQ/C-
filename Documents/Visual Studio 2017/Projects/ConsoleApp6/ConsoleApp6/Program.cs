using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
     static class Program
    {
        static void Main(string[] args)
        {
            string s = "小红今天去上课";
            string s2 = "红天今去课上小";
            Console.WriteLine(GetSimilarityWith(s,s2));
            Console.ReadKey();
        }
        public static decimal GetSimilarityWith(this string sourceString, string str)

        {



            decimal Kq = 2;

            decimal Kr = 1;

            decimal Ks = 1;



            char[] ss = sourceString.ToCharArray();

            char[] st = str.ToCharArray();



            //获取交集数量
            var sss = ss.Intersect(st);
            int q = ss.Intersect(st).Count();

            int s = ss.Length - q;

            int r = st.Length - q;



            return Kq * q / (Kq * q + Kr * r + Ks * s);

        }
    }

}
