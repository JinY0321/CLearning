using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배치고사문제
{
    class Program1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("숫자를 입력하세요.");
                string answer = Console.ReadLine();

                bool isSuccess = int.TryParse(answer, out int result);
                //숫자 입력시 true, result에 입력된 숫자 저장됨.

                while (isSuccess != false)
                {
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("짝수입니다.");
                    } else
                    {
                        Console.WriteLine("홀수입니다.");
                    }
                        
                } Console.WriteLine("숫자가 아닙니다.");
            }
        }
    }
}
