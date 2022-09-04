using System; 

// 직사각형 별 찍기
// 이 문제에는 표준 입력으로 두 개의 정수 n과 m이 주어집니다.

namespace CodingTestPractice_01
{
    class program
    {
        static public void Main(string[] args) 
        {

            // String[] s;

            // Console.Clear();
            // s = Console.ReadLine().Split(' ');



            // Console.WriteLine("{0}", a + b);

            // Console.WriteLine("*"); 

            // for(int i = 0; i < 5; i++)
            // {
                
            //     Console.Write("*");
            // }

            // for(int i = 0; i < 3; i++)
            // { 

            //     for(int j = 0; j < 5; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine("");
            // }
            // 별(*) 문자를 이용해 가로의 길이가 n, 세로의 길이가 m인 직사각형 형태를 출력해보세요.
            // n과 m은 각각 1000 이하인 자연수입니다.

            // int a = Int32.Parse(s[0]);     가로길이
            // int b = Int32.Parse(s[1]);     세로길이 

            // *
            // ** 
            // *** ... 
            // **** 
            // ***** 

            // for(int i = 1; i <= 5; i++)               // 줄 
            // { 

            //     for(int j = 0; j < i; j++)           // 행 
            //     {
                    
            //         Console.Write("*");
            //     }
            //     Console.WriteLine("");

            // }


            for(int i = 0; i < 5; i++)               // 줄 
            { 
                for(int j = 4; j > i; j--)           // 행 
                {
                    Console.Write(" ");
                }

                for(int k = 0; k < i+1; k++)
                { 
                    Console.Write("*");
                }
                Console.WriteLine(""); 

            }

            
            // for(int i = 0; i < 5; i++)               // 줄 
            // { 
            //     for(int j = 4; j > i; j--)           // 행 
            //     {
            //         Console.Write(" ");
            //     }

            //     for(int k = -1;     or    k <= i; k++)
            //     { 
            //         Console.Write("*");
            //     }
            //     Console.WriteLine(""); 

            // }




            


    




            



        }
    }

}