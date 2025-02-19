using System;

public class Class
{
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
