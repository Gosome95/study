using System;

namespace _p1_myTextRPG
{
    class MainClass
    {
        enum alchohlType            // 구조체로 역기 
        {
            None = 0,
            Korean = 1,
            European = 2,
            American = 3
        }

        struct Player
        {
            public int hp;
            public int attack; 
        }

        static alchohlType ChooseAlType()
        {
            Console.WriteLine("[1] Korean  : kind of a Warrior. based on [Soju]");
            Console.WriteLine("[2] European : kind of a Archer. based on [Wine]");
            Console.WriteLine("[3] American : kind of a Sworder. based on [Whiskey]");
            Console.WriteLine("Please Select your Character with main alchol type! : ");

            alchohlType choice = alchohlType.None; 
            string input = Console.ReadLine();

            string[] alType = new string[3] { "[Korean]", "[European]", "[American]" };
            int result = (int)choice - 1;

            switch (input)
            {
                case "1":
                    choice = alchohlType.Korean;
                    result = (int)choice - 1;
                    Console.WriteLine("Welcome. your select is " + alType[result]);
                    break;

                case "2":
                    choice = alchohlType.European;
                    result = (int)choice - 1;
                    Console.WriteLine("Welcome. your select is " + alType[result]);

                    break;
                case "3":
                    choice = alchohlType.American;
                    result = (int)choice - 1;
                    Console.WriteLine("Welcome. your select is " + alType[result]);
                    break;

            }
            return choice; 
        }

        static void CreatePlayer(alchohlType choice, out Player player)
        {
            switch (choice)
            {
                case alchohlType.Korean:
                    player.hp = 100;
                    player.attack = 10;
                    break;

                case alchohlType.European:
                    player.hp = 80;
                    player.attack = 12;
                    break;

                case alchohlType.American:
                    player.hp = 60;
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
            Console.WriteLine("안녕하세요!");
            Console.WriteLine("술이 있어 즐거운 세상, <주락이 월드> 입니다");
            Console.WriteLine("표시언어가 변경됩니다 : English");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("There are some Characters you should choose");
            Console.WriteLine();
            // 기본 안내메세지

            // 본격적으로 게임이 돌아가는 부분 
            while(true)
            {
                alchohlType choice = ChooseAlType();
                // jobclass 선택

                //캐릭터 생성
                if (choice != alchohlType.None)
                {
                    Player player;
                    CreatePlayer(choice, out player);

                    Console.WriteLine($"your charcter HP : {player.hp} & attack : {player.attack}");
                    break;
                }
                   
                
            }



        }
    }
}
