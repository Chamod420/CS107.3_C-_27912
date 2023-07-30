using System;

namespace DistanceConverterApp
{
    public class ConvertValues
    {
        public void KilometerToMeter()
        {
            Console.Write("Enter the distance in kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            double meters = kilometers * 1000;

            Console.WriteLine($"Distance in meters: {meters} m");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            ConvertValues converter = new ConvertValues();
            converter.KilometerToMeter();

            Console.ReadKey();
        }
    }
}
