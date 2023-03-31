using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct Point3D      //struct 구조체 키워드 (값형식-스택)
    {
        public int x;
        public int y;
        public int z;

        public Point3D(int x, int y, int z)  //구조체의 생성자 (매개변수가 없는 생성자는 없다.)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()   //System.Object 형식의 ToString()메소드를 오버라이딩
        {
            return string.Format($"{x}, {y}, {z}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Point3D p3d1;
            p3d1.x = 10;
            p3d1.y = 20;
            p3d1.z = 40;

            Console.WriteLine(p3d1.ToString()); //10, 20, 40

            Point3D p3d2 = new Point3D(100, 200, 300);
            Point3D p3d3 = p3d2;
            p3d3.z = 400;

            Console.WriteLine(p3d2.ToString()); // 100, 200, 300
            Console.WriteLine(p3d3.ToString()); // 100, 200, 400
        }
    }
}
