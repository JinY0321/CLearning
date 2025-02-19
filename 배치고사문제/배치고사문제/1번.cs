using System.Diagnostics.CodeAnalysis;

namespace 배치고사문제
{
    internal class Program
    {
        //1번
        static int Sum(int[] arr)
        {
            // TODO : 배열의 모든 요소의 합을 계산하는 코드 작성
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            } return sum ;
        }

        static void Main(string[] args)
        {
            int[] ints = { 3, 6, 7, 9 };
            Console.WriteLine(Sum(ints));
        }

        //2번
        static void Add(int result, int i)
        {
            result += i;
        }

        static void Main(string[] args)
        {
            int total = 10;
            Console.WriteLine(total);
            Add(200, total);
            Console.WriteLine(total);
        }

        //3번
        class Square
        {
            float width;
            float height;

            float Area() { return width * height; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Square box = new Square();
                Console.WriteLine(box.Area()); //서로 다른 클래스 내부에 있는 멤버를 사용하려고 했기 때문에.
            }
        }

        //4번 
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;

            x += x * ++y;

            Console.WriteLine(x++);
        }
        //출력결과?
        // x=2, y=3
        //++y = 4
        //x*4=8
        //x+=8 은 10
        //x++은 10 출력후 x가 11이 된다.
    }
}
