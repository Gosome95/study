using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 97; 
            bool isPrime = true;
            // 소수를 판별하는 코드 
            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    isPrime = false; 
                    break;   // 특정 키워드만 빠져나가게 되어있다 
                }
            }
            if (isPrime)
            {
                 System.Console.WriteLine("소수입니다");
            } else
            {
                System.Console.WriteLine("소수가 아닙니다");
            }

            // continue문 
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    System.Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
                }
            }
            
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 != 0)             // 이 값이 아니면 
                {
                    continue;              // 우리가 원하는 조건을 만족하지 않으면 continue  //한번 loop가 끝난것처럼 가장하고 다시 반복문 실행 
                    // 가독성이 좋다 
                }
                stem.Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");

            }
            
        }
    }
}