using System;
using System.Collections.Generic;

class Program9
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Pop();
        Console.WriteLine(stack.Pop());
        stack.Push(4);
        stack.Push(5);

        while (stack.Count > 0)
            Console.WriteLine(stack.Pop());
    }
} //출력결과 작성
//2541
//stack 은 후입선출 구조로 먼저 입력되는 데이터가 나중에 출력되는 방식이기 때문에 코드를 순서대로 따라가면 2541이다.