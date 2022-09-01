using System;

namespace _p4_CreateMonster
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

        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }

        struct Monster
        {
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

        static void CreateRandomMonster(out Monster monster)
        {
            // 랜덤으로 1~3몬스터 중 하나를 리스폰
            Random rand = new Random();
            int radnMonster = rand.Next(1, 4);  // 앞은 포함 뒤는 제외  1 ~3
            switch (radnMonster)
            {
                // 정수형으로 받아온건데 monster 타입은 enum타입이라서 변환이 필요하다 
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임이 스폰되었습니다");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;

                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 스폰되었습니다");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;

                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤이 스폰되었습니다");
                    monster.hp = 30;
                    monster.attack = 3; 
                    break;

                default:
                    monster.hp = 0;
                    monster.attack = 0; 
                    break; 
            }
        }

        static void EnterField()
        {
            Console.WriteLine("필드에 접속했습니다");

            // 랜덤으로 1~3몬스터 중 하나를 리스폰
            // [1] 전투 모두로 돌입
            // [2] 일정 확률로 마을로 도망        여기서 구현하고자 하는 것 

            // 비스하게 작업했던 [캐릭터 생성] 작업을 응용
            Monster monster;

            //CreateRandomMonster(choice, out player);
            // 원래 캐릭터 생성에서 초이스는 12,3중 입력을 받아서 만드는건데 여기서는 랜덤 생성이니까 없애주자
            CreateRandomMonster(out monster);

            //안내메시지 보여주기
            Console.WriteLine("[1] 전투 모두로 돌입");
            Console.WriteLine("[2] 일정 확률로 마을로 도망");

        }

        static void EnterGame()
        {
            while (true)
            {   // 잘못된 값을 넣으면 다시 선택할 수 있도록 반복문으로 
               
                // 게임 접속해서 안내메시지
                Console.WriteLine("게임에 접속했습니다!");
                Console.WriteLine("[1] 필드로 간다");
                Console.WriteLine("[2] 로비로 돌아가기");

                string input = Console.ReadLine();
                //switch (input)
                //{
                //    case "1":
                //        break;
                //    case "2":
                //        return;
                //        // break문은 switch문에서만 빠져나가게 된다 그래서 while문을 빠져나가게 해야함
                //        // 그래서 쓰는 가장 간단한 방법은 [return]
                //        //아니면 아래처럼 if문 쓰기 
                //}
                if (input == "1")
                {
                    //enterField()
                }
                else if (input == "2")
                {
                    break;
                    // 여기 break문은 switch문과 다르게 바로 while문을 빠져나가도록 해준다 
                }    
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

                    EnterGame();
                    // 게임에 접속하는 메시지 


               
                }
            }

        } // Main 함수 대쉬 
    }
}
