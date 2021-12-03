using System;
using System.Collections.Generic;
using System.Text;

namespace _2021.tasks
{
    class Day2
    {
        public Day2()
        {
            /*
                forward X increases the horizontal position by X units.
                down X increases the depth by X units.
                up X decreases the depth by X units.
            */

            List<Tuple<string, int>> movements = new List<Tuple<string, int>>();

            foreach (string line in System.IO.File.ReadAllLines(@"C:\Users\ricky\Desktop\adventofcode2021\2021\2021\tasks_inputs\day2.txt"))
            {
                string[] s = line.Split(" ");
                movements.Add(Tuple.Create(s[0], int.Parse(s[1])));
            }

            Console.WriteLine(Part1(movements));
        }

        int Part1(List<Tuple<string, int>> moves)
        {
            int horizontal = 0;
            int depth = 0;
            foreach (Tuple<string, int> move in moves)
            {
                string direction = move.Item1;
                if(direction == "forward")
                {
                    horizontal += move.Item2;
                }

                if(direction == "up")
                {
                    depth -= move.Item2;
                }

                if(direction == "down")
                {
                    depth += move.Item2;
                }
            }

            return horizontal * depth;
        }
    }
}
