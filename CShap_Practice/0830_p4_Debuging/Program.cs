using System;

namespace _p4_Debuging
{
    // 메소드 호출 -> Inception
    // 현실 -> 1차꿈 > 2차 꿈 -> 3차 꿈

    // 메소드 역시 위치를 기억할 필요가 있다
    // 메인이 현실이라고 볼 수 있음 

    class Program
    {
        public static void Print(int value)
        {
            Console.WriteLine(value);         // 매개변수값 value 출력 이 예제에서는 아래 ret 이 여기에 매개변수로 들어가게 되어있음 
        }

        public static int ADD(int a, int b)
        {
            int ret = a + b;
            Print(ret);
            return ret;
        }
        public static void Main(string[] args)
        {
            // int ret = Program.ADD(10, 20);
            // 빨간원은 이 프로그램 실행시 여기까지만 실행되도록 일시정지  Breakpoint

            //ret = ret + 1; 
            //Console.WriteLine(ret);

            // 디버그] 메뉴에서 프로시저 = 함수 or 메소드
            // 실행단위가 메소드 단위

            Program.ADD(5, 15);
            Program.ADD(6, 17);
            Program.ADD(3, 11);
            Program.ADD(12, 31);
            Program.ADD(10, 20);


        }  
    }
}
