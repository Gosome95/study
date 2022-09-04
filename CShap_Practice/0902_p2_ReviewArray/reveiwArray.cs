using System;
using System.Linq; 

namespace _p2_ReviewArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 아래의 배열에서 최소값과 최대값을 구하는 코드를 작성하시.
            // int[ ] data = {100, 2, 4, -3, 69, 21, 0);

            int[] data = new int[] { 69, 2, 4, -3, 100, 21, 0 };

            int Maxnum = 0;
            int Minnum = 0;
            
            for (int i = 0; i < data.Length; i++)          // 숫자 일일히 세지말고 길이 맞추어주는 함수 사용 
            {
               if ( data[i] > Maxnum)
                    Maxnum = data[i];
            }
            Console.WriteLine("최댓값 입니다 : " + Maxnum);

            for (int j = 0; j < data.Length; j++)
            {
                if (data[j] < Minnum)
                    Minnum = data[j]; 
            }
            Console.WriteLine("최솟값 입니다 : " + Minnum);


            //강사님 코드

            int min = data[0];
            int max = data[0];

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] < min)
                    min = data[i];

                if (data[i] > max)
                    max = data[i];
            }

            Console.WriteLine("최소값 = " + min);
            Console.WriteLine("최대값 = " + max);

            int max_value = Math.Max(10, 20);

            int[] array1 = { 0, 1, 5, 2, 8 };
            int[] array2 = { 9, 4 };

            int max1 = array1.Max();
            Console.WriteLine(max1);

        }
    }
}
