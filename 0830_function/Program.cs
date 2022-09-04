using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // Mwrhod   = Function  
        // 한정자 반환형식  함수이름 (매개변수 목록)
        // 유저 체력, 힐을 주는 등 다 함수로 구현 가능 
        static int ADD(int a, int b) 
        {
            int result = a + b;
            return result; 
        }

        //하나씩 증가시키는 함수
        static void ADDOne(ref int number)
        {
            number = number + 1; 
        }
        // 입력으로 받는 [매개변수]를 복사로 넘길 수 있고, 참조로 넘길 수 있음 
        // 기본 형식은 [복사]
        // [ref]를 붙여주면  reference 참조값으로, 실제로 a 메모리로 변수를 넘기겠다 
        // 입력받을 때 [ref]를 붙여서 [진퉁]으로 작업하겠다  

        //범용적인 함수 디자인 방식 (추천)
        // 반환하는 형식을 [int]로 만든다음에 반환
        static int ADDOne2(int number)
        {
            number = number + 1; 
        }

        // 진퉁을 사용하는 경우
        static void Swap (ref int a, ref int b)
        {
            int temp = a;  //곧바로 대입하면 값이 바뀌니까  // 임시저장으로 원본저장 
            a = b; 
            b = temp;  // b값의 temp a 원본을 넣어줘야 함 
        }

        // out 설명 
        // 값을 여러개를 받아서 반환해야하는 경우 [참조타입] 사용은 out  
        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a/b; 
            result2 = a % b;  
        }

        static void Main(string[] args)
        { 
            int a = 0;     // 이름을 보고 어떤 값이 들어갈지 선택하지 말고... 같
            Program.ADDOne(ref a);   // 위 함수부분에서도 ref를 써주고 한번더 내가 참조값으로 넘기는 걸 알아! 라고 표시. 
            System.Console.WriteLine(a);


            // 위 함수 ref 없으면 이대로는 결과가 0 
            // 왜냐하면 a가 넣어지는 게 아니라 a가 들고 있는 값 0이 복사되어서 함수로 전달된다 
            // 그래서 a에서 사용할 값 자체는 변화가 없음. 

            // 복사 = 짝퉁   |  참조 = 진퉁

            // 이 두번째 방식이 선호됨 
            // 값을 저장만하는 용도로도 사용할 수가 있음 (첫번재 버전은 진퉁으로만 작업, 우리가 원하는게 결과보다 그저 test라면 번거로움)
            int b = Program.ADDOne2(a);            
            a = b; 
            Console.WriteLine(a); 


            // 찐퉁을 사용하는 경우 
            // swap. 짝퉁을 보내봤자  우리가 사용하는 실제 값이 달라지지 않음 
            int num1 = 1;
            int num2 = 2; 
            Program.Swap(ref num1, ref num2); 
            System.Console.WriteLine(num1);
            System.Console.WriteLine(num2);

            // out 개념 설명 
            int num3 = 10;
            int num4 = 3; 

            int result1;
            int result2; 
            Divide(10, 3, out result1, out result2);

            System.Console.WriteLine(result1);
            System.Console.WriteLine(result2);


        }
    }
}