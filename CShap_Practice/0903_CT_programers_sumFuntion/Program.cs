using System;

namespace _CT_programers_sumFuntion
{
    class MainClass
    {
        // 두 정수 a, b가 주어졌을 때 a와 b 사이에 속한 모든 정수의 합을 리턴하는 함수, solution을 완성하세요.
        // 예를 들어 a = 3, b = 5인 경우, 3 + 4 + 5 = 12이므로 12를 리턴합니다.
        // a, b대소가 정해져 있지 않음 

        static public long solution(int a, int b)
        {
            long answer = 0;
            int start = 0;
            int end = 0;

            // a, b 대소 비교를 위한 로직
            // 합산 
            // 반복 
          
            if ( a < b)
            {
                start = a;
                end = b;
                int count = end - start + 1;

                int[] arr = new int[count];
                arr[0] = start;
                long sum = start;
                int nextumber = start + 0; 

                for (int i = 0; i < arr.Length; i++)
                {
                    nextumber = start + i;
                    arr[i] = nextumber; 
                }

                for (int i = 1; i < arr.Length; i++)
                {
                    sum = sum + arr[i]; 
                }
                answer = sum; 
            }
            else
            {
                start = b;
                end = a;
                int count = end - start + 1;

                int[] arr = new int[count];
                arr[0] = start;
                long sum = start;
                int nextumber = start + 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    nextumber = start + i;
                    arr[i] = nextumber;
                }

                for (int i = 1; i < arr.Length; i++)
                {
                    sum = sum + arr[i];
                }
                answer = sum;

            }

            return answer;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            long test = MainClass.solution(3, 7);
            Console.WriteLine("두 자연수 합 :" + test);


            long test2 = MainClass.solution(7, 3);
            Console.WriteLine("두 자연수 합 :" + test2);

            
        }
    }
}
