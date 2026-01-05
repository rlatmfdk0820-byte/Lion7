using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 10;
            string hi = "안녕하세요";
            string name = "김김이";


            Console.WriteLine("이름 : " + name + " ,나이 : " + age + " ,대사 : " + hi);
            Console.WriteLine("이름 : {0}, 나이 : {1}, 대사 : {2}" , name, age, hi);
            Console.WriteLine($"이름 : {name}, 나이 : {age}, 대사 : {hi}");

            int a = 10;
            int b = 2;

            Console.WriteLine(a * b);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a % b);
            Console.WriteLine(a / b); 
        }
    }
}
