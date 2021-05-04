using System;

namespace CSBasic32
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            } else if(DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간입니다.");
            } else
            {
                Console.WriteLine("저녁 먹을 시간입니다.");
            }

            double score = 3.5;
            if(score == 4.5)
            {
                Console.WriteLine("신");
            } else if(score <= 4.2) 
            {
                Console.WriteLine("교수님의 사랑");
            }
            else if (score <= 3.5)
            {
                Console.WriteLine("모범생");
            }
            else if (score <= 2.8)
            {
                Console.WriteLine("일반인");
            }
            else if (score <= 1.5) 
            {
                Console.WriteLine("오락의 신");
            }
            else if (score <= 1.0)
            {
                Console.WriteLine("불가촉천민");
            }
            else if (score <= 0.5)
            {
                Console.WriteLine("자벌레");
            }
            else if (score <= 0)
            {
                Console.WriteLine("플랑크톤");
            }
        }
    }
}
