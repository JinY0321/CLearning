namespace _1주차_강의_과제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("섭씨 온도를 입력하세요: ");
            //string input = Console.ReadLine();

            //if (double.TryParse(input, out double celsius))
            //{
            //    double fahrenheit = (celsius * 9 / 5) + 32;
            //    Console.WriteLine($"화씨 온도: {fahrenheit:F2}°F");
            //}
            //else
            //{
            //    Console.WriteLine("유효한 숫자를 입력하세요.");
            //}

            Console.Write("몸무게(kg)를 입력하세요: ");
            string weightInput = Console.ReadLine();

            Console.Write("키(m)를 입력하세요: ");
            string heightInput = Console.ReadLine();

            if (double.TryParse(weightInput, out double weight) && double.TryParse(heightInput, out double height))
            {
                double bmi = weight / (height * height);
                Console.WriteLine($"BMI 지수: {bmi:F2}");
            }
            else
            {
                Console.WriteLine("유효한 숫자를 입력하세요.");
            }
        }
    }
}
