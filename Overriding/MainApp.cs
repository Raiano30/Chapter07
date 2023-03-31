using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class ArmorSuite  //부모클래스
    {
        public virtual void Initialize()  //오버라이딩: 부모클래스 멤버에 virtual 있어야 자식에서 재정의 가능
        {
            Console.WriteLine("Armored");
        }
    }
    class IronMan : ArmorSuite           //자식클래스
    {
        public override void Initialize() //오버라이딩 : 자식클래스 멤버에 override 키워드로 재정의
        {
            base.Initialize();            //부모클래스 메서드 기능 가져오기
            Console.WriteLine("Repulsor Rays Armed"); //새 기능
        }
    }
    class WarMachine : ArmorSuite       //자식클래스
    {
        public override void Initialize() //override
        {
            base.Initialize();
            Console.WriteLine("Double-Battel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launsher Armed");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorSuite = new ArmorSuite();      //클래스를 객체화 인스턴스화
            armorSuite.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuite ironman = new IronMan();            //다형성 특징으로 인해 armorsuite 타입에 ironman객체 형성 가능
            ironman.Initialize();

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();      //다형성 특징으로 인해 armorsuite 타입에 warmachine객체 형성 가능
            warmachine.Initialize();
        }
    }
}
