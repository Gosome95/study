using System;

namespace _p2_otherCode
{
    class MainClass
    {

        enum ClassType                   //switch문에서 [스트링] 타입 input을 향후에도 쑬 수 있도록 타입을 변환해주는 역할
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3

        }

        // 원래 메인으로 작성했던 것을 함수 기능으로 빼버리기
        // choice 를 내부에서도 선언해주고 외부에도 알리는 방법이 필요함     ref or out 쓰기 
        // 인자가 하나밖에 없으니까 [반환타입] 으로 돌려주기 
        static ClassType ChooseClass()                   
        {
            Console.WriteLine("직업을 입력해주세요 : ");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 기사");
            Console.WriteLine("[3] 기사");

            ClassType choice = ClassType.None;                     // 메인에서 선언했던 것을 여기로 가지고 옮
                                                                 
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }

            return choice;
            // 일종의 다잉메세지
            // choice 자체는 이 함수 내부에서만 유효한게 맞음 스택에 쌓임
            // 그러나 반환타입은 이 값을 복사해달라고 요청하는 것
            // 이 반환한 값을 외부에도 사용할 수 있음 
        }

        public static void Main(string[] args)
        {
            while (true)                                      // 여기 조건식을 ( choice != ClassType.None ) 이런식으로 하고 아래 빠져나오는 분기문을 없애도 ok
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                    break; 
            }
        }
    }
}
