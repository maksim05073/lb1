namespace lb1_1
{
    internal class Program
    {
        static void Main()
        {//f
            Console.Write("Введіть значення a: ");
            double a = float.Parse(Console.ReadLine());
            Console.Write("Введіть значення b: ");
            double b = float.Parse(Console.ReadLine());
            double sum = a + b;
            if (sum == 0)
            {
                Console.WriteLine("Помилка: ділення на нуль!");
                return;
            }
            double result = Math.Pow(sum, 3) + a * Math.Cos(sum) + (a * Math.Sqrt(Math.Abs(b)) / sum);
            Console.WriteLine($"Результат обчислення: {result}");
        }
    }
}