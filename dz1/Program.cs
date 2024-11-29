using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number: 1 == detsimetre, 2 == kilometre, 3 == metre, 4 == milimetre, 5 == santimetre;"); var number = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("emter length:"); double length = double.Parse(Console.ReadLine());


            double Length = 0;

            switch (number)
            {
                case 1: 
                    Length = length * 0.1;
                    break;
                case 2: 
                    Length = length * 1000;
                    break;
                case 3: 
                    Length = length;
                    break;
                case 4: 
                    Length = length * 0.001;
                    break;
                case 5: 
                    Length = length * 0.01;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine($"length in metre: {Length}");
        }
    }
}