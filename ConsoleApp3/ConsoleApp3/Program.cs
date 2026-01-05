using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////같은 데이터 타입의 변수를 쉼표로 구분해 한 번에 선언
            //int x=10, y=20, z=30; //정수형 xyz선언하고 초기화

            //Console.WriteLine(x); //출력 : 10
            //Console.WriteLine(y); //출력 : 20
            //Console.WriteLine(z); //출력 : 30


            //int age = 20;
            ////Console.WriteLine("나이: {0}",age);

            //string name = "철수";
            ////Console.WriteLine("이름:{0}.나이:{1}", name, age);

            ////Console.WriteLine("나이: "+ age);

            //Console.WriteLine($"나이: {age},이름: {name}");


            //3d 좌표값 예시
            int posx = 0, posy = 50, posz = 100;

            Console.WriteLine("x: " + posx + "y: " + posy + "z: " + posz);
            Console.WriteLine("x: {0},y:{1}, z:{2}", posx, posy, posz);
            Console.WriteLine($"좌표: {posx}, {posy}, {posz}");

            int red = 255, green = 128, blue = 0;

            Console.WriteLine("red: " + red + "green: " + green + "blue: " + blue);
            Console.WriteLine("red: {0},green:{1}, blue:{2}", red, green, blue);
            Console.WriteLine($"RGB: {red}, {green}, {blue}");

            string name = "김철수";
            int age = 25;
            string greeting = "안녕하세요 좋은 아침입니다";

            Console.WriteLine("이름: " + name+"나이:"+ age+ "대사: " + greeting);
            Console.WriteLine("이름: {0}, 나이:{1}, 대사:{2}", name, age, greeting);
            Console.WriteLine($"이름:{name}, 나이:{age}, 대사:{greeting}");




        }
    }
}
