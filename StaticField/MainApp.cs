using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
    class Global
    {
        public static int Count = 0;  //전역변수, 멤버변수//static : 인스턴스화 필요없이. Global.count로 불러올 수 있다.
    }
    class Global2
    {
        public int count = 0; 
    }
    class ClassA
    {
        public ClassA() //생성자 : 한정자  +  클래스 이름과 같다. 
        {
            Global.Count++;

            Global2 a = new Global2(); //static이 아닐 때 인스턴화 
            a.count++;  //독립성을 가지므로 다른 클래스 참조시 new로 불러올 수 없다.
        }
    }
    class ClassB
    {
        public ClassB() //생성자
        {
            Global.Count++;
        }
    }
    class MainApp
    {
        static void Main()
        {
            Console.WriteLine($"Global.Count : {Global.Count}");
            new ClassA(); //힙에 객체 생성만 하고 만다. 스택의 공간은 없다. 다시 찾아서 접근할 수 없다.
            new ClassA();
            new ClassB();
            new ClassB();
            Console.WriteLine($"Global.Count : {Global.Count}");
        }
    }
}
