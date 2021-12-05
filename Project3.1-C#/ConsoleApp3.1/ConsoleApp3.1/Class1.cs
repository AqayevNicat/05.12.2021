using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._1
{
    internal class Class1
    {
        public void MyString(string word)
        {
            string res = "";
            string myres = "";
            for (int i = word.Length-1; i >=0 ; i--)
            {
                res += word[i];
            }
            for (int n = res.Split(" ").Length-1; n >=0 ; n--)
            {
                myres += res.Split(" ")[n] + " ";
            }

            Console.WriteLine(myres);
        }
    }
}
