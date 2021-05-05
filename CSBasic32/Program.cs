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

            Console.WriteLine("이번달은 몇 월인가요? ");
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 12: case 1: case 2:
                    Console.WriteLine("겨울");
                    break;
                case 3: case 4: case 5:
                    Console.WriteLine("봄");
                    break;
                case 6: case 7: case 8:
                    Console.WriteLine("여름");
                    break;
                case 9: case 10: case 11:
                    Console.WriteLine("가을");
                    break;
                default:
                    Console.WriteLine("지구에 있는거 맞나요?");
                    break;
            }

            string input_2 = Console.ReadLine();
            int number = int.Parse(input_2);
            Console.WriteLine((number > 0) ? "자연수입니다." : "자연수가 아닙니다.");

            Console.Write("입력:");
            string line = Console.ReadLine();
            if(line.Contains("안녕"))
            {
                Console.WriteLine("너도 안녕~");
            } else if (line.Contains("바보"))
            {
                Console.WriteLine("너도 바보야!");
            } else if(line.Contains("밥"))
            {
                Console.WriteLine("배고파!");
            } else
            {
                Console.WriteLine("심심해~");
            }

            Boolean isLoop = true;

            while (isLoop) {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽");
                        break;
                    case ConsoleKey.Escape:
                        Console.Write("으악!");
                        isLoop = false;
                        break;
                    default:
                        Console.WriteLine("UnknownKey!");
                        break;
                 }
            }
    
        }
    }
}
