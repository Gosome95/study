using System;

namespace _p1_Baekjoon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            //string[] arrInput = input.Split();
            // space로 배열 인덱스 구분 

            //Console.WriteLine(int.Parse(arrInput[0]) + int.Parse(arrInput[1]));

            // 실제 백준에 제출한 코드
            // 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

            ///////////////////정답코드 
            string[] _input = Console.ReadLine().Split();
            //C#에서 입력을 받아오기 위해서는 Console.ReadLine() 을 사용
            //사용자가 입력하는 한 줄을 문자열로 입력받을 수 있다.

            //공백을 두고 숫자 2개가 한줄에 입력된다고 한다.
            //즉, 숫자 두개를 나눠서 저장해야하는데 이는 Split() 를 통해서 가능하다.
            //Split()은 문자열을 나눠주는 메소드인데() 안에 아무것도 넣지 않으면 공백을 기준으로 자른다.
            //Split(",") 이렇게 적는다면 문자열에서 ,를 찾아서 전부 잘라준다.
            //Split()을 사용해서 문자열을 자르게되면 문자열이 여러개가 된다.
            //고로, 배열을 통해서 저장해주면 손쉽게 담아둘 수 있다.


             Console.WriteLine(int.Parse(_input[0]) + int.Parse(_input[1]));
            // 문자열을 int로 바꾸기 위해서는 int.Parse() 를 써주면 된다.


        }
    }
}
