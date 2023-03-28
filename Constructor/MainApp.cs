using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Cat
    {
        public Cat()  //생성자 오버로딩, 매개변수가 없는 생성자
        {
            Name = "";
            Color = "";
        }
        public Cat(string _Name, string _Color) //생성자 오버로딩, 매개변수가 있는 생성자
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat()   //종료자 클래스 이름 앞에 '~' //프로그램 실행 중에는 종료 시점 모르지만, 프로그램이 종료될 때 발동된다. 
        {
            Console.WriteLine($"{Name} : 잘가");
        }

        public string Name;   //필드, 전역변수, 멤버변수
        public string Color;  //필드, 전역변수, 멤버변수

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야용");
        }

    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");               //객체 생성과 동시에 초기값을 부여
            kitty.Meow();                                       //클래스의 메소드 발동
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
