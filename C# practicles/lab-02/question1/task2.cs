using System;

namespace DistanceConverterApp
{
    public class ConvertValues
    {
        public void KilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000;

            Console.WriteLine($"Distance in meters: {meters} m");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance in kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            converter.KilometerToMeter(kilometers);

            Console.ReadKey();
        }
    }
}
