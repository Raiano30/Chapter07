using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class WaterHeater
    {
        protected int temperature; //protected 외부에서는 접근X, 파생클래스(상속자)는 접근 O

        public void SetTemperature(int temperature)
        {
            if(temperature < -5 || temperature > 42) // 또는
            {
                throw new Exception("Out of temperature range"); //throw 던진다. catch부분으로 // new :생성 // Excption 스트링 받는다
            }
            this.temperature = temperature; //this. 나의. 
        }
        internal void TurnOnWater() //같은 어셈블리 코드에서만 public으로 접근 O
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            try //예외처리 조건 
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50); //예외처리
                heater.TurnOnWater();      //실행안됨

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
