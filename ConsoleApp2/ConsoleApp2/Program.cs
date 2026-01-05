using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 리터럴 : 코드에서 고정된 값을 의미
            //int number = 25;
            //double pi = 3.14;
            //char letter = 'A';
            //string name =   "Alice";

            //Console.WriteLine(number);
            //Console.WriteLine(pi);
            //Console.WriteLine(letter);
            //Console.WriteLine(name);


            //리터럴연습 
            //플레이 스코어 100
            //파이 3.14
            //등급 'A'
            //플레이어 이름 홍길동

            //int number = 100;
            //double pi = 3.14;
            //char letter= 'A';
            //string name = "홍길동";

            // Console.WriteLine("플레이 스코어"+ number);
            // Console.WriteLine("파이"+pi);
            // Console.WriteLine("등급"+letter);
            // Console.WriteLine("플레이어 이름"+ name);


            ////변수 선언 후 값 저장
            //string greeting;
            //greeting = "안녕하시와요";//변수 값 지정

            ////출력하기
            //Console.WriteLine(greeting);


            ////변수 초기화
            //int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.5; // 실수형 변수 선언과 초기화
            //string city = "seoul"; //문자열 변수 선언과 초기화

            ////변수
            //Console.WriteLine(score); //출력: 100
            //Console.WriteLine(temperature); //출력: 36.5
            //Console.WriteLine(city); // 출력:seoul

            //방법1: 선언 후 할당 (두 줄)
            int health;
            health = 100;

            //방법2: 선언과 동시에 초기화 (한 줄)
            int maxhealth = 100;
            int damage = 15;

            // 게임 로직 출력
            Console.WriteLine("체력 : " + health + "/" + maxhealth);

            //데미지를 받았습니다.
            Console.WriteLine("데미지 수치" + damage);



            

        }
    }
}
