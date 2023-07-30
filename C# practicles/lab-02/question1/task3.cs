using System;

namespace DistanceConverterApp
{
    public class ConvertValues
    {
        public double KilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000;
            return meters;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance in kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            double meters = converter.KilometerToMeter(kilometers);

            Console.WriteLine($"Distance in meters: {meters} m");

            Console.ReadKey();
        }
    }
}
