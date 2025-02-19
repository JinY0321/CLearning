using System;

class Program
{
    public class Unit
    {
        public virtual void Move()
        {
            Console.WriteLine("두발로 걷기");
        }

        public void Attack()
        {
            Console.WriteLine("Unit 공격");
        }
    }

    public class Marine : Unit
    {

    }

    public class Zergling : Unit
    {
        public override void Move()
        {
            Console.WriteLine("네발로 걷기");
        }
    }

    static void Main(string[] args)
    {
        Zergling zerg = new Zergling();
        zerg.Move();
    }
}
//출력결과?
//네발로 걷기 출력.
// Zergling클래스 내부에서 Move 메서드가 오버라이딩 되어있기 때문에, Zergling 클래스로 생성된 객체의 Move메서드에서
//저장된 내용이 출력된다.
