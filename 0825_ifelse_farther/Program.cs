using System; 

namespace ifesle_ExamplePractice 
{ 
    class program 
    { 

        enum Choice 
        { 
            Rock = 1,       // 아무것도 입력안하면 순서대로 0 , 1 ,2 로 자동 할당됨 
            Paper = 2,       // 우리는 명시적으로 값을 넣ㅇ준것 
            Scissors = 0
        }


        static public void Main(string[] args) 
        { 
            // 0: 가위 1:바위 2: 보 

            // - 아래 [가위, 바위, 보]게임을 만들때 [0 1 2]가 각각 무엇인지 찾느라 계속 헤맸음
            // - 강제로 [숫자]를 인위적으로 박아넣는건 해선 안될일! ~ 하드코딩
            // - 그래서 하나의 변수로 빼는 방법

            // const int ROCK = 1; 
            // const int PAPER = 2; 
            // const int SCISSORS = 0; 
            // 일부러 대문자를 해놓은 것은 얘녜 수치를 바꾸면 안된다는 뜻에서 
            // 명명을 다르게 적용 
            // 상수로 적용했음 

            // 상수가 많아지면 [이름]이 겹치지 않도록 주의해야한다
            // 그리고 가위바위보는 연관성을 띄고 있기 때문에 하나의 그룹으로 묶고 싶다 
            // 그래서 나오는게 열거형 

            Random rand = new Random(); 
            int aiChoice = rand.Next(0, 3);  // 0~2사이의 랜덤 값 
            // rand Next 호출할 수가 있음 
            // 첫번째 값은 포함되고  두번째 max값은 포함이 안된다 

            Console.WriteLine("당신의 선택을 입력해주세요 : "); 
            int choice = Convert.ToInt32(Console.ReadLine());
            // Console.ReadLine 콘솔창에서 엔터를 누를때까지 기다린다 
            // 값 입력하는 거 

            // 내가 고른값 
            switch (choice) 
            { 
                case (int)Choice.Scissors:                        // 그냥 가져오면 형태가 [enum] 그래서 (int)로 변환
                    Console.WriteLine("당신의 선택은 가위입니다.");     // 상수가 더좋다 하면 그렇게 바꾸어줘도 무관 
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("당신의 선택은 바위입니다."); 
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("당신의 선택은 보입니다."); 
                    break;
            }
            //switch case문 사용할때 값이 고정되어있는 값을 사용해야 한다 
            // 그래서 변수를 바꾸지 않겠다 해서 위에 [const] 추가 


            

            // 컴퓨터가 고른값 출력 
            switch (aiChoice) 
            { 
                case SCISSORS: 
                    Console.WriteLine("컴퓨터의 선택은 가위입니다."); 
                    break;
                case ROCK:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다."); 
                    break;
                case PAPER:
                    Console.WriteLine("컴퓨터의 선택은 보입니다."); 
                    break;
            }

            // 0: 가위 1:바위 2: 보 
            // 코드 0824 버전보다 좀더 간편하게 
            if (choice == aiChoice) 
            { 
                Console.WriteLine("결과는 비겼습니다"); 
            }
            else if (choice == SCISSORS && aiChoice == PAPER) 
            {
                Console.WriteLine("Player 승"); 
            }
            else if (choice == ROCK && aiChoice == SCISSORS)
            { 
                Console.WriteLine("Player 승"); 
            }
            else if (choice == PAPER && aiChoice == ROCK)
            {
                Console.WriteLine("Player 승"); 
            }
            else
            {
                Console.WriteLine("Player 패"); 
            }


        


        }

    }
}