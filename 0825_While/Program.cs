using System; 

namespace WhilePractice
{
    class program 
    { 
        static public void Main(string[] args) 
        { 
            // while 반복문 
            // 조건이 만족한다면 [참이라면]
            // 그 다음줄을 실행 
            // 그리고 다시 조건체크하고 실행 
            // if문과 비슷한데 뒤끝인게 나간다 


            // Hellor world를 다섯번 출력하고 싶다 
            int count = 5; 
            // 특정 조건 하에서 [Hellor world]를 출력하고 싶다 

            while(count > 0)
            { 
                Console.WriteLine("Hello World"); 
                count --;
                // count = count - 1; 
            }
            // 조건을 제대로 짜지 않는다면 [무한루프]가 발생한다 


            // 사촌형제  do while 
            // 일단은 들어와서 do 구문을 한번은 실행한다 
            // 그 다음에 while문을 체크해서 다시 do구문을 돌릴지 빠져나갈지 결정한다 

            // do 
            // {

            // } while (); 

            // 꼭 한번은 실행해야 된다는 걸 실무에서는 그렇게 많이 접하지는 않는다 

            ///////////////////////////////////
            // 간단한 프로그렘 : 거울아 거울아 ~ 

            string answer;
            do 
            {
                Console.WriteLine("강사님은 잘생시셨나요? (y/n) : "); 
                answer = Console.ReadLine();

                if (answer == "y" || answer == "Yes" || answer == "y")  // 중복정답 판별
                {
                    break;
                }

            } while (answer != "y" || answer != "Yes" || answer != "y");       // 변수 유효범위는 중괄호 안에 있음\
            // 와우... ['y'] 이렇게해서 한번 오류뜸 ㄷ ㄷ 

            // 조건을 || or 로 하셨기 때문입니다.
            // 조건 중에서 2개는 당연히 [y가 아니거나 Y 아니거나 Yes가 아닌 상태] true 일 테니,
            // 최종 결과물도 true라서 무한 루프를 도는 것이죠.

            Console.WriteLine("정답입니다"); 
            








           

        }

    }
}