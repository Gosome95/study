using System;

namespace _overloading
{
    class MainClass
    {
        // 오버로딩 ? 
        // 함수이름의 재사용 or (변수이름의 재사용 )

        public static int ADD(int a, int b)
        {
            Console.WriteLine("ADD int 호출");
            return a + b; 
        }

        //함수 이름을 재사용하고 싶어
        // 같은 이름을 사용할거면 매개변수 타입과 개수가 정확하게 일치하면 안된다 
        public static float ADD(float a, float b)
        {
            Console.WriteLine("ADD float 호출");
            return a + b;
        }

        // 개수를 달리하는 버전도 가능 
        //public static int ADD(int a, int b, int c)
        //{ 
        //    Console.WriteLine("ADD int 호출");
        //    return a + b + c;
        //}

        // 선택적 매개변수
        // 앞의 두번째는 필수인데 뒤는 옵션
        // 만약 세번째를 아무것도 입력 안하면 세번재 인자는 기본값 0 으로 사용 
        public static int ADD(int a, int b, int c = 0, float d = 1.0f, double e = 3.0)
        {
            Console.WriteLine("ADD int 호출");
            return a + b + c;
        }
        // 이 문법은 함수 인자가 많아질 때 유용하다
        // 다 넣어줄거면 [순서]를 잘 지켜주어야 한다 

        public static void Main(string[] args)
        {
            int ret = MainClass.ADD(2, 3);
            Console.WriteLine(ret);

            float ret2 = MainClass.ADD(2.0f, 3.0f);

            //선택적 매개변수
            // C#은 어느 하나만 지정해주는게 가능하다  
            MainClass.ADD(1, 2, d: 2.0f); 

        }
    }
}
