using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex001
    {
        public void Run()
        {
            Car001 car = new Car001();
            car.setSize("세단");
            car.setColor("하얀");

            Console.WriteLine("고객님의 차. {0} {1}이...", car.getColor(), car.getSize());

            car.Engine_on(); // 메서드 호출 시 괄호 추가
            car.Back();
            car.Left();
            car.Right();
            car.Engine_off();
        }
    }

    class Car001
    {
        private string size;
        private string color;

        public void setSize(string size)
        {
            this.size = size;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return color; // 반환값 추가
        }

        public string getSize() // getSize 메서드 추가
        {
            return size;
        }

        public void Engine_on()
        {
            Console.WriteLine("시동을 켭니다.");
        }

        public void Engine_off()
        {
            Console.WriteLine("시동을 끕니다.");
        }

        public void go()
        {
            Console.WriteLine("전진합니다.");
        }

        public void Back()
        {
            Console.WriteLine("후진합니다.");
        }

        public void Left()
        {
            Console.WriteLine("좌회전 합니다.");
        }

        public void Right()
        {
            Console.WriteLine("우회전 합니다."); // 불필요한 세미콜론 제거
        }
    }
}
