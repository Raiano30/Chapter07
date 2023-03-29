using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Employee //getter setter방식
    {
        private string Name;       //private: 외부접근 X, 클래스 내부에서는 접근 O
        private string Position;
        //public으로하나 바뀌는 것 같지만 private쓰는 것 보안성때문에 그렇다.

        public void SetName(string Name) //Set : 쓰다 //데이타 베이스 보낼때 암호화
        {
            this.Name = Name;            //전역변수의 Name = 매개변수 Name;
        }
        public string GetName()          //Get  //데이타베이스 받을때 복호화
        {
            return Name;
        }
        public void SetPosition(string Position)
        {
            this.Position = Position;   //전역변수 = 매개변수
        }
        public string GetPosition()
        {
            return this.Position;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
        }
    }
}
