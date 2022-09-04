using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        public class sunwoo
        {
            public string name;
            public bool gender;       // 남 = 1 // 여 = 0 

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = new int[] { {4, 5, 6}, {7, 8, 9}}; 
            sunwoo sun1 = new sunwoo;  

            sun1.name = "kim"; 




        }
    }
}