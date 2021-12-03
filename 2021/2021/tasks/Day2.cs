using System;
using System.Collections.Generic;
using System.Text;

namespace _2021.tasks
{
    class Day2
    {
        public Day2()
        {
            List<Tuple<string, int>> movements = new List<Tuple<string, int>>();

            foreach (string line in System.IO.File.ReadAllLines(@"C:\Users\ricky\Desktop\adventofcode2021\2021\2021\tasks_inputs\day2.txt"))
            {
                string[] s = line.Split(" ");
                movements.Add(Tuple.Create(s[0], int.Parse(s[1])));
            }

            Console.WriteLine(Part1(movements));
            Console.WriteLine(Part2(movements));
        }

        int Part1(List<Tuple<string, int>> moves)
        {
            int horizontal = 0;
            int depth = 0;

            foreach (Tuple<string, int> move in moves)
            {
                string direction = move.Item1;
                int units = move.Item2;

                if(direction == "forward")
                {
                    horizontal += units;
                }

                if(direction == "up")
                {
                    depth -= units;
                }

                if(direction == "down")
                {
                    depth += units;
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

                if (direction == "forward")
                {
                    horizontal += units;
                    depth += (aim * units);
                }

                if (direction == "up")
                {
                    aim -= units;
                }

                if (direction == "down")
                {
                    aim += units;
                }
            }

            return horizontal * depth;
        }
    }
}
