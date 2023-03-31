using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Base
    {
        protected string Name; //생성자,  protected 자식 클래스까지 접근 가능
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }
        ~Base()               //종료자 : 가비지 컬렉터로 삭제되기 전에 발동
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }
        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod");
        }
    }
    class Derived : Base //클래스 상속
    {
        public Derived(string Name) : base(Name) //base키워드 : 생성자의 매개변수로 넘어간다 
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }
        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived()");
        }
        public void DerivedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();     //부모클래스의 메소드 발동
            b.DerivedMethod();
        }//가비지컬렉터가 힙에있는 데이터 지워나간다. 역순으로 지운다. //자식의 종료자 발동 > 부모의 종료자 발동
    }
}
