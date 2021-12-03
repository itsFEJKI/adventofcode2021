using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _2021.tasks
{
    class Day2
    {
        public Day2()
        {
            Stopwatch stopwatch = new Stopwatch();
            List<Tuple<string, int>> movements = new List<Tuple<string, int>>();
            stopwatch.Start();
            foreach (string line in System.IO.File.ReadAllLines(@"C:\Users\ricky\Desktop\adventofcode2021\2021\2021\tasks_inputs\day2.txt"))
            {
                string[] s = line.Split(" ");
                movements.Add(Tuple.Create(s[0], int.Parse(s[1])));
            }

            Console.WriteLine("Part1: {0}", Part1(movements));
            Console.WriteLine("Part2: {0}", Part2(movements));
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time {0} ms", stopwatch.ElapsedMilliseconds);
        }

        int Part1(List<Tuple<string, int>> moves)
        {
            int horizontal = 0;
            int depth = 0;

            foreach (Tuple<string, int> move in moves)
            {
                string direction = move.Item1;
                int units = move.Item2;

                switch(direction)
                {
                    case ("forward"):
                        horizontal += units;
                        break;
                    case ("up"):
                        depth -= units;
                        break;
                    case ("down"):
                        depth += units;
                        break;
                }

            }

            return horizontal * depth;
        }

        int Part2(List<Tuple<string, int>> moves)
        {
            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            foreach (Tuple<string, int> move in moves)
            {
                string direction = move.Item1;
                int units = move.Item2;

                switch(direction) {
                    case ("forward"):
                        horizontal += units;
                        depth += aim * units;
                        break;
                    case ("up"):
                        aim -= units;
                        break;
                    case ("down"):
                        aim += units;
                        break;
                }
            }

            return horizontal * depth;
        }
    }
}
