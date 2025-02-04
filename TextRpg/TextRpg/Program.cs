namespace TextRpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine("\n1. 상태보기 \n2. 인벤토리 \n3. 상점");
            Console.WriteLine("\n원하는 행동을 입력해주세요.\n");

            string mainInput = Console.ReadLine();

            if (mainInput == "1") {
                //상태보기
            }
            else if (mainInput == "2") {
                //인벤토리
            }
            else {
                //상점열기.
            }
        }
    }
}
