using System;
using System.Collections.Generic;

namespace CSBasic4
{
    class Program
    {
        //클래스 안에 클래스 사용 가능
        //class FirstClass
        //{
        //}
   static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(1, 19));
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            //List<int> list = new List<int>();
            //list.Add(5);
            //list.Add(64);
            //list.Add(32);

            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            List<int> list = new List<int>() { 50, 273, 32, 64 };

            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "  item: " + item);
                list.Remove(item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Round(52.263));


        }
    }

    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetIntTime()
        {
            this.inTime = DateTime.Now;
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }

    }

}
