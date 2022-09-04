using System;

namespace _p3_lecture21
{
    class MainClass
    {
        // 절차(procedure) 지향 ~ 함수를 기반으로 짜는 방식. 함수로 엮어서 쓴다 심플하고 직관적이다 
        // 프로그램이 커지면 커질수록 유지보수가 힘들다
        // 함수의 호출순서가 무척 중요하다! 함수자체가 [순서]에 종속적이게 된다
        // PvP 나 기능을 추가하려면 Fight 이상의 함수가 추가되어야 함

        // 객체 지향 (OOP Object Oriented Programming)
        // 객체 = 프로그램 내 모든 것들 눈에 보이는 것, 눈에 보이지 않는 것 모두
        // 속성과 기능으로 구분 

        // Knight
        // 속성 : hp, attack(공격력), pos(position), STR DEX ... 
        // 기능 : Move, Attack(다른 객체 공격), Die
        // 객체를 만들 때는 얘가 할 수 있는 모든 걸 떠올려서 묘사 그 다음 속성과 기능을 조합해서 프로그래밍

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
