using System;

namespace _p1_SelectTextRPG
{
    class MainClass
    {
        // MMORPG TEXT RPG 만들기


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] jobClass = new string[3] { "[1] 기사", "[2] 궁수", "[3] 법사" };


            int userSelect; 
            bool isPrime = true; 

            while ( isPrime )
            {
                if ( isPrime != false)
                {
                    Console.WriteLine("직업 입니다  : ");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(jobClass[i]);
                    }
                    Console.WriteLine("직업 넘버를 넣어주세요 : ");
                    userSelect = Convert.ToInt32(Console.ReadLine());

                    if (userSelect == 1 || userSelect == 2 || userSelect == 3)
                    {
                        int result = userSelect - 1; 
                        Console.WriteLine("당신의 직업은" + jobClass[result] + "입니다");
                        isPrime = false;
                    } 
                    //continue; 
                } 

            }

            // 강사 코드






        }
    }
}
