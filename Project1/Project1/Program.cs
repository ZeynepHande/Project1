using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var data = GetSampleData();
            CalculateResult(data);
        }

        private static List<Inputs> GetSampleData()
        {
            var samples = new List<Inputs>();

            samples.Add(new Inputs(1, 2));
            samples.Add(new Inputs(3, 7));
            samples.Add(new Inputs(0, 6));
            samples.Add(new Inputs(1, 1));
            samples.Add(new Inputs(-5, 2));
            samples.Add(new Inputs(1, 5));
            samples.Add(new Inputs(3, -5));

            return samples;
        }

        private static void CalculateResult(List<Inputs> data)
        {
            var parallelX = new List<int>();
            var parallelY = new List<int>();

            for (int i = 0; i < data.Count; i++)
            {
                for (int j = i; j < data.Count; j++)
                {
                    if (data[i].X == data[j].X && data[i].Y != data[j].Y)
                    {
                        if (!parallelY.Contains(data[i].X))
                        {
                            parallelY.Add(data[i].X);
                        }
                    }
                    else if (data[i].Y == data[j].Y && data[i].X != data[j].X)
                    {
                        if (!parallelX.Contains(data[i].Y))
                        {
                            parallelX.Add(data[i].Y);
                        }
                    }
                }
            }

            Console.WriteLine("X Eksenine Paralel Doğruların Sayısı: " + parallelX.Count());
            foreach (var item in parallelX)
            {
                Console.WriteLine($"\ty={item}");
            }

            Console.WriteLine("Y Eksenine Paralel Doğruların Sayısı: " + parallelY.Count());
            foreach (var item in parallelY)
            {
                Console.WriteLine($"\tx={item}");
            }

        }
    }
}