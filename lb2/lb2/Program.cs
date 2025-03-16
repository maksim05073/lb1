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
        if (n == 0)
        {
            return 1;
        }
        else
        {
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
    static void task2()
    {
        double s = 1;
        int n = 1;
        for (int i = 1; n <=3; n++)
        {
            if (i == 4) i = 1;
            switch (i)
            {
                case 1:
                    s += (Math.Cos(n * (Math.PI / 4)) / fact(n)) * Math.Pow(Math.PI / 6, 2);
                    break;
                case 2:
                    s += (Math.Cos(n * (Math.PI / 4)) / fact(n)) * Math.Pow(Math.PI, 2);
                    break;
                case 3:
                    s += (Math.Cos(n * (Math.PI / 4)) / fact(n)) * Math.Pow(-5 * Math.PI, 2);
                    break;
            }
            i++;
        }
        double z1 = (Math.PI / 6) / Math.Sqrt(2);
        double z2 = (Math.PI) / Math.Sqrt(2);
        double z3 = (-5 * Math.PI) / Math.Sqrt(2);
        double y1 = Math.Exp(z1) * Math.Cos(z1);
        double y2 = Math.Exp(z2) * Math.Cos(z2);
        double y3 = Math.Exp(z3) * Math.Cos(z3);
        Console.WriteLine($"y1 = {y1}");
        Console.WriteLine($"y2 = {y2}");
        Console.WriteLine($"y3 = {y3}");
        Console.WriteLine($"sum = {s}");
    }
    static void Main(string[] args)
    {
        task1();
        task2();
        Console.ReadKey();
    }
}
