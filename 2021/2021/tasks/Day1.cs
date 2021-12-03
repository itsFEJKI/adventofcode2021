using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _2021.tasks
{
    public class Day1
    {
        public Day1()
        {
            Stopwatch stopwatch = new Stopwatch();
            string[] textArray = System.IO.File.ReadAllText(@"C:\Users\ricky\Desktop\adventofcode2021\2021\2021\tasks_inputs\day1.txt").Split("\n");
            int[] dives = Array.ConvertAll(textArray, s => int.Parse(s));
            stopwatch.Start();
            Console.WriteLine("Part1: {0}", Part1(dives));
            Console.WriteLine("Part2: {0}", Part2(dives));
            stopwatch.Stop();
            Console.WriteLine("Elapsed time: {0}ms", stopwatch.ElapsedMilliseconds);
        }

        int Part1(int[] dives)
        {
            int increments = 0;
            for(int i = dives.GetLowerBound(0); i < dives.GetUpperBound(0); i++)
            {
                if (dives[i] < dives[i + 1])
                    increments++;

            }
            return increments;
        }

        int Part2(int[] dives)
        {
            int prev = dives[0] + dives[1] + dives[2];
            int increments = 0;

            for (int i = 0; i < dives.Length - 2; i++)
            {

                if (prev < dives[i] + dives[i + 1] + dives[i + 2])
                    increments++;

                prev = dives[i] + dives[i + 1] + dives[i + 2];

            }

            return increments;
        }
    }
}