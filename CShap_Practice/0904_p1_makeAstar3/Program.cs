using System;

namespace _p1_makeAstar3
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int input = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < input; i++)                 // 만들고 싶은 숫자 5가정 그걸 input으로 교체 
            //{
                
            //    for (int j = input; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(""); 
            //}

            //for (int i = 0; i < input; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}



            for (int i = 0; i < input; i++)              /// 행 
            {
                
                if ( (input - (i*2)) < 1 )
                {
                    for (int k = input - 1; k > i; k--)
                    {
                        Console.Write(" ");
                    }

                    for ( int j = 0; j < input - ((input - i -1) *2) ; j++)                /// input, 
                    {
                        Console.Write("*");
                    }

                }
                else
                {
                    for (int k = 0; k < i; k++ )
                    {
                        Console.Write(" "); 
                    }

                    for (int j = 0; j < input - (i * 2); j++)        // i = 행이니까 행을 줄이는 것 --  
                    {
                        Console.Write("*");

                    }
                }

                Console.WriteLine("");
            }



        }
    }
}
