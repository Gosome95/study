using System;

namespace CT_Programers
{
    class program
    {
        // public class Solution 
        // {
    
        //     string[] _Day = new string[] {SUN, MON, TUE, WED, THU, FRI, SAT};
    
        //     public string solution(int a, int b) 
        //     {
        
        
        //         string answer = "";
        //         return answer;
        
        //     }
        // }

        static public void Main(string[] args)
        {

            string[] _Day = new string[7] {"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};

            // int a = Convert.ToInt32(Console.ReadLine());
           
            // // 1 -> SUN 

            // int b = Convert.ToInt32(Console.ReadLine()); 

            // // 31일   1, 3, 5, 7    |     8, 10, 12 
            // // 30일   4 , 6         |     9, 11 

            if (a == 1 )
            {

            }else if (a == 2)
            {
                b += 31; 
            }else if (a == 3)
            {
                b += 31 + 29; 
            }else if (a == 4)
            {
                b += 31 + 29 + 31; 
            }else if (a == 5)
            {
                b += 31 + 29 + 31 + 30; 
            } else if (a == 6) 
            {
                b += 31 + 29 + 31 + 30 + 31; 
            } else if (a == 7)
            {
                b += 31 + 29 + 31 + 30 + 31 + 30; 
            } else if (a == 8)
            {
                b += 31 + 29 + 31 + 30 + 31 + 30 + 31; 
            }
            else if (a == 9)
            {
                b += 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31; 
            }else if (a == 10)
            {
                b += 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30; 
            } else if (a == 11) 
            {
                b += 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31; 

            } else if (a == 12)
            {
                b += 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30; 
            } 

            if (b % 7 == 1)
            {
                answer = _Day[5]; 
            } else if (b % 7 == 2)
            {
                answer = _Day[6]; 
            } else if (b % 7 == 3)
            {
                answer = _Day[0]; 
            } else if (b % 7 == 4) 
            {
                answer = _Day[1]; 
            } else if (b % 7 == 5)
            {
                answer = _Day[2]; 
            } else if (b % 7 == 6)
            {
                answer = _Day[3]; 
            } else if (b % 7 == 0)
            {
                answer = _Day[4]; 
            }





    
        }
    }
}