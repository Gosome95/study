using System;

namespace _p1_ReviewFunction
{
    class MainClass
    {
        // 함수 사용의 이유 ~ 코드를 기능별로 묶어서 사용할 필요가 있어
        // C# 기준 메소드
        // 어떤 기능들의 묶음 
        // c++ ~ function, 다른언어 프로시저

        // | 한정자 반환형식 이름 (매개변수 목록)  |        <- 문법 

        // 함수 ~  수학에서 어떤 입력을 넣었을 때 어떤 [출력]을 뱉어버리는 것 || 어떤 기능들의 묶음 
        // 반환형식 ~ 넘길게 없으면 일단 void 그리고 매개변수도 비워놓을 수 있음
        static void HelloWorld()            // 돌려받을 값도 없고, 넣을 값도 없다 
        {
            Console.WriteLine("Hello World");
        }

        //넣은 입력값에 따라 출력을 받아와야 하는 경우
        // 덧셈 함수
        // 이름을 정해주고 그 다음에 [입력하는 것] [출력하는 것] 다 정해주어야 하는데
        // 출력하는 형식은 [정수 만 할거니까 int
        // 입력을 받을 때는 숫자 두 개를 입력 받아야 하니까 int a  int b  -> 첫번째도 정수, 두번째도 정수를 받아가지고
        // 우리가 어떠한 연산(중괄호 안 기능)을 한다음에 다시 정수형으로 뱉어주겠다 선언
        // 값을 뱉어줄 때 사용하는 것이 [return] 
        static int ADD(int a, int b)
        {
            return a + b; 
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HelloWorld();   // 이렇게 해도 되고
            MainClass.HelloWorld();   // 이렇게 써도 된다
            //동일한 class 내라면 Program.을 생락하셔도 됩니다.
            //다른 클래스에서 해당 기능을 사용하려면 Program.Add()를 넣어주면 되구요.
            //이 부분은 나중에 OOP를 다뤄야 이해할 수 있습니다.

            int result = MainClass.ADD(4, 5);
            Console.WriteLine(result);

        }
    }
}
