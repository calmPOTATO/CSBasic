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


            Product product = new Product();
            product.name = "감자";
            product.price = 2000;
            Console.Write(product.name + " : " + product.price + "원");


            Product product2 = new Product() { name = "짜장면", price = 5500 };
            Product product3 = new Product() { name = "짬뽕", price = 8000 };
            Product product4 = new Product() { name = "탕수육"};
            Product product5 = new Product() { price = 999999999 };
            Product product6 = new Product() { price = 8000, name = "양장피" };


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

    class MyMath
    {
        public static double PI = 3.141592;
        public int num = 123;
        public static void Greeting()
        {
            //인스턴스 변수에는 인스턴스가 생성될 때 만들어지기때문에 클래스 내에서 인스턴스 변수는 접근이 안됨
            Console.WriteLine(PI);
            Console.WriteLine("Greting~!");
        }
    }

}
