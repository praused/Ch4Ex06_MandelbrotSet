using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Ex06_MandelbrotSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realMax = 1.77;
            double realMin = -0.6;
            double imagMax = -1.2;
            double imagMin = 1.2;
            double realStep, imagStep;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            while (true)
            {
                realStep = (realMax - realMin) / 79;
                imagStep = (imagMax - imagMin) / 48;
                for (imagCoord = imagMin; imagCoord >= imagMax; imagCoord += imagStep)
                {
                    for (realCoord = realMin; realCoord <= realMax; realCoord += realStep)
                    {
                        iterations = 0;
                        realTemp = realCoord;
                        imagTemp = imagCoord;
                        arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                        while ((arg < 4) && (iterations < 40))
                        {
                            realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp) - realCoord;
                            imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                            realTemp = realTemp2;
                            arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                            iterations += 1;
                        }
                        switch (iterations % 4)
                        {
                            case 0:
                                Console.Write(".");
                                break;
                            case 1:
                                Console.Write("o");
                                break;
                            case 2:
                                Console.Write("O");
                                break;
                            case 3:
                                Console.Write("@");
                                break;
                        }
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("Current Limits:");
                Console.WriteLine($"realCoord from {realMin} to {realMax}");
                Console.WriteLine($"imagCoord from {imagMin} to {imagMax}");
                Console.WriteLine("Enter new limits:");
                Console.WriteLine("realCoord from:");
                realMin = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("realCoord to:");
                realMax = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("imagCoord from:");
                imagMin = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("imagCoord to:");
                imagMax = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
