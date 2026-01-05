using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = "Hello World!";

            Console.WriteLine(content);

            int age = 10;
            string name = "김철수";
            string relatio = "형";

            Console.WriteLine($"이름 : {name},나이 : {age}, 관계 : {relatio}, 대사 : {content}");
            Console.WriteLine("이름 : " + name + ", 나이 : " + age + ", 관계 : " + relatio + ", 대사 : " + content);
            Console.WriteLine("이름 : {0}, 나이 : {1},관계 : {2},대사 : {3}", name, age, relatio, content);
 




        }
    }
}
