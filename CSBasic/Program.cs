using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            int alpha;
            int Alpha;
            //int a★; C#은 이모지로 변수명 지정 못함
            //int 한글숫자; 변수명으로 한글도 가능은 하지만 쓰지 말것

            //inline 주석
            /*
             *  comment
             */

            //출력
            Console.Write("이건 개행되지 않는다. = print");
            Console.WriteLine("이건 개행된다");

            //자료형
            //Integer
            Console.WriteLine(53 + 272 - 123);
            Console.WriteLine(53 * 3 - 3);
            Console.WriteLine(14 / 2);
            Console.WriteLine(14 / 3); //4
            Console.WriteLine(14 % 3); //2

            //Real Number (실수)
            Console.WriteLine(13.123); //숫자에 .이 들어있으면 실수, C#은 기본적으로 double임
            Console.WriteLine(0); //0과 0.0은 다르다.
            Console.WriteLine(0.0);
            Console.WriteLine(14.0 / 2.0); //7.0
            Console.WriteLine(14.0 / 3); //4.~~~~~


            //Character
            Console.WriteLine('A'); //문자
            Console.WriteLine("A"); //문자열
            Console.WriteLine("\t 탭 \\역슬래시 \n 개행 \" ");
            Console.WriteLine("미\t림여자정보과학고");
            Console.WriteLine("미림\t여자정보과학고");
            Console.WriteLine("미림여\t자정보과학고");
            Console.WriteLine("미림여자\t정보과학고");
            Console.WriteLine("미림여자정\t보과학고");
        }
    }
}
