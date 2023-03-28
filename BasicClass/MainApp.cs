using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    class Cat
    {
        public string name;
        public string color;

        public void Meow()
        {
            Console.WriteLine($"{name} : 야옹");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat(); //Cat kitty - 클래스 변수 생성해서 공간 확보, new는 클래스 호출 연산자, cat();는 생성자
                                   //형성된 객체인 kitty는 '인스턴스'라고 함
                                   //Cat kitty = new Cat();는 '인스턴스화'작업
            kitty.color = "하얀색";
            kitty.name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.name} : {kitty.color}");

            Cat nero = new Cat();
            nero.color = "검은색";
            nero.name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.name} : {nero.color}");
        }
    }
}
