using System;
public class Lb1_2
{
    public static void Main()
    {
        double y;
        StreamReader input = new StreamReader("LAB2.txt");
        StreamWriter output = new StreamWriter("RES.txt");
        double x;
        for (int i = 0; i < 9; i++)
        {
            x = double.Parse(input.ReadLine());
            y = Math.Sqrt(x) * Math.Exp(-x);
            output.WriteLine("***************************************");
            output.WriteLine($"*    x={x}     y={y}    *");
            output.WriteLine("***************************************");
        }
        output.WriteLine("Tаблицю склав студент ФЕКІ: Навроцький Максим");
        output.Close();
        input.Close();
    }
}
