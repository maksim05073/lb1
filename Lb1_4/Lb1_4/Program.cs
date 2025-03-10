using System;
class Program
{
    private static int GetFuelConsumptionForWeight(int weight)
     {
         if (weight > 2000) return -1;
         if (weight > 1500) return 9;
         if (weight > 1000) return 7;
         if (weight > 500) return 4;
         return 1;
     }
    private static bool CanReachPoint(int distance, int fuelCapacity, int fuelConsumption, int remainingFuel = 0, int additionalFuelRequired = 0)
          {
              int fuelRequired = fuelConsumption * distance;
              if (fuelRequired >= 0)
                  return true;
              else 
                  return false;
          }
    public static void ExecuteTask4()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        try
        {
            using (StreamReader input = new StreamReader("fly.txt"))
            {
                int fuelCapacity = int.Parse(input.ReadLine());
                int distanceAB = int.Parse(input.ReadLine());
                int distanceBC = int.Parse(input.ReadLine());
                int cargoWeight = int.Parse(input.ReadLine());
                int fuelConsumption = GetFuelConsumptionForWeight(cargoWeight);
                if (cargoWeight >=2000)
                {
                    Console.WriteLine("Літак не може підняти такий вантаж.");
                    return;
                }

                int remainingFuel = fuelCapacity - (distanceAB * fuelConsumption);
                if (remainingFuel<=0)
                {
                    Console.WriteLine("Літак не може долетіти до пункту B.");
                    return;
                }
                int fuelRequiredForC = fuelConsumption * distanceBC;
                int additionalFuelRequired = Math.Max(0, fuelRequiredForC - remainingFuel);
                bool canReachC = CanReachPoint(distanceBC, fuelCapacity, fuelConsumption, remainingFuel, additionalFuelRequired);
                if (canReachC)
                    Console.WriteLine("Політ можливий, необхідно дозаправити " + additionalFuelRequired + " літрів у пункті B.");
                else
                    Console.WriteLine("Літак не може долетіти до пункту C навіть після дозаправки.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не знайдено.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Невірний формат даних у файлі.");
        }
    }
    static void Main()
    {
        ExecuteTask4();
        Console.ReadKey();
    }
}
