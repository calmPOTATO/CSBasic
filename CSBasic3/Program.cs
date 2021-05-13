using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[100];
            Console.WriteLine(intArray.Length);
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);
            //Console.WriteLine(intArray[100]);
            //Console.WriteLine(intArray[-1]);

            int i = 0;
            int[] intArray2 = { 52, 273, 32, 65, 103 };

            while(i<=intArray2.Length)
            {
                Console.WriteLine(i + "번째 출력 )" + intArray2[i]);
                i++;
            }

            string input;
            do
            {
                Console.Write("입력 (종료 : exit)");
                input = Console.ReadLine();
            } while (input != "exit");

            for(int j = '가'; j<'힣'; j++)
            {
                Console.Write((char)j);
            }


            int[] intArray3 = { 1, 2, 3, 4, 5, 6 };
            for(int k = intArray3.Length-1; i>=0; i++ )
            {
                Console.WriteLine(intArray3[i]);
            }

            for(int k=intArray3.Length; k>0; k--)
            {
                Console.WriteLine(intArray3[k - 1]);
            }

            string [] fruits = { "사과", "배", "포도", "딸기", "멜론" };

            for(i = 0; i<10; i++)
            {

                for(int j=0; j<10-i; j++)
                {
                    Console.Write(' ');
                }

                for(int j=0; j<i+1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            string input3 = "Potato Tomato";
            Console.WriteLine(input3.ToUpper());
            Console.WriteLine(input3.ToLower());

            string dirtyInput = " text um\n\t";
            Console.WriteLine("[" + dirtyInput + "]");
            Console.WriteLine("[" + dirtyInput.Trim() + "]");

            string[] foodArrays2 = { "감자", "고구마", "토마토", "가지", "파프리카" };
            Console.WriteLine(string.Join(" ", foodArrays2));
            Console.WriteLine(string.Join(", ", foodArrays2));


            int x = 1;
            while(x<50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

            }
        }
    }
}
