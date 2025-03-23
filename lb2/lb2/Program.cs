class Program
{ 
    static void task1()
    {
        double y, x=0,xmax=360, a;
        using (StreamReader input = new StreamReader("lb2_1a.txt"))
        {
            for (double i = x; i < xmax; i=i+6)
            {
                a = double.Parse((input.ReadLine()));
                y = (Math.Pow(Math.Cos(2 * a * i), 2)) / (3 * a);
                Console.WriteLine($"y = {y}");
            }
            input.Close();
        }
    }
    static double fact(int n)
    {
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum *= i;
        }
        return sum;
    }
    static double computeS(double x)
    {
        double s = 1;
        double term;
        int n = 1;

        do
        {
            term = (Math.Cos(n * (Math.PI / 4)) / fact(n)) * Math.Pow(x, n);
            s += term;
            n++;
        } while (Math.Abs(term) >= 1e-6); // Додаємо члени ряду, доки їх значення >= 10⁻⁶

        return s;
    }
    static void task2()
    {
        double[] xValues = { Math.PI / 6, Math.PI, -5 * Math.PI };

        foreach (double x in xValues)
        {
            double s = computeS(x);
            double z = x / Math.Sqrt(2);
            double y = Math.Exp(z) * Math.Cos(z);

            Console.WriteLine($"Для x = {x:F6}");
            Console.WriteLine($"Обчислене S(x) = {s:F6}");
            Console.WriteLine($"Точне y(x) = {y:F6}");
            Console.WriteLine($"Похибка = {Math.Abs(s - y):E6}");
            Console.WriteLine(new string('-', 30));
        }
    }
    static void Main(string[] args)
    {
        //task1();
        task2();
        Console.ReadKey();
    }
}