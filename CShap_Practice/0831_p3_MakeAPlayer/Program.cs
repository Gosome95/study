using System;

namespace _p3_MakeAPlayer
{
    class MainClass
    {
        enum ClassType
        {
         //switch문에서 [스트링] 타입 input을 향후에도 쑬 수 있도록 타입을 변환해주는 역할
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        struct Player
        {
            // hp, attakc, 마나 등 나중을 위해 새로 구조체로 받아오기
            public int hp;
            public int attack;
        }
  
        static ClassType ChooseClass()
        {
         // 원래 메인으로 작성했던 것을 함수 기능으로 빼버리기
         // choice 를 내부에서도 선언해주고 외부에도 알리는 방법이 필요함     ref or out 쓰기 
         // 인자가 하나밖에 없으니까 [반환타입] 으로 돌려주기

            Console.WriteLine("직업을 입력해주세요 : ");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 마법사");

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

        static void CreatePlayer(ClassType choice, out Player player)
        {   // choice를 아래에서도 사용해야하기 때문에 함수 인자로 받아줘야 함
            // 위에서 Player 구조체를 만들었으므로 이걸 이용하자
            // 구조체 장점은 함수 인자를 하나하나 추가해줄 필요없이 그 [대장 ]을 그냥 넣어주면 된다 

            // 기사 100/10  궁수 75/12   마법사 50/15
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15; 
                    break;

                default:
                    player.hp = 0;
                    player.attack = 0;
                    break; 
            }
        }

        public static void Main(string[] args)
        {
            while (true)                                      // 여기 조건식을 ( choice != ClassType.None ) 이런식으로 하고 아래 빠져나오는 분기문을 없애도 ok
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                {
                    //캐릭터생성
                    //int hp;
                    //int attack;
                    // 그런데 여기에 하나씩 다 추가하는건 너무 번거롭잖아 만약 마나부터 시작해서 10개 스텟 추가해야 된다?
                    // 그래서 나온 개념이 구조체 사용
                    Player player; 

                    CreatePlayer(choice, out player);

                    Console.WriteLine($"HP{player.hp} Attack{player.attack}");
                }
            }


        }
    }
}
