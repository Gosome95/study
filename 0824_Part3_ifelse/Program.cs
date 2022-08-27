using System; 

namespace ifesle_ExamplePractice 
{ //test
    class program 
    { 
        static public void Main(string[] args) 
        { 
            // 0: 가위 1:바위 2: 보 

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
                case 0: 
                    Console.WriteLine("당신의 선택은 가위입니다."); 
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다."); 
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보입니다."); 
                    break;
            }
            

            // 컴퓨터가 고른값 출력 
            switch (aiChoice) 
            { 
                case 0: 
                    Console.WriteLine("컴퓨터의 선택은 가위입니다."); 
                    break;
                case 1:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다."); 
                    break;
                case 2:
                    Console.WriteLine("컴퓨터의 선택은 보입니다."); 
                    break;
            }

            // 0: 가위 1:바위 2: 보 
            if (choice == aiChoice) 
            { 
                Console.WriteLine("결과는 비겼습니다"); 
            }
            else if (choice == 0 && aiChoice == 2) 
            {
                Console.WriteLine("Player 승"); 
            }
            else if (choice == 0 && aiChoice == 1)
            {
                Console.WriteLine("Player 패"); 
            }
            else if (choice == 1 && aiChoice == 0)
            { 
                Console.WriteLine("Player 승"); 
            }
            else if (choice == 1 && aiChoice == 2)
            {
                Console.WriteLine("Player 패"); 
            }
            else if (choice == 2 && aiChoice == 1)
            {
                Console.WriteLine("Player 승"); 
            }
            else if (choice == 2 && aiChoice == 0)
            {
                Console.WriteLine("Player 패"); 
            }

            






        }

    }
}