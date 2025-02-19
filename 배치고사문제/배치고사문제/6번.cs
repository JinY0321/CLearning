using System;

public class Class2
{
	public Class2()
	{
        static void Main(string[] args)
        {
            int[] intArr = { 4, 7, 2, 5, 6, 8, 3 };

            Array.Sort(intArr);

        foreach (int i in intArr)
                Console.Write(i + " ");
        }
    }
}
