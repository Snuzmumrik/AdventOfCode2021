using System;
using System.IO;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader input = File.OpenText("./input.txt"))
            {
                int prevDepth = Int32.Parse(input.ReadLine());
                int counter = 0;
                while (!input.EndOfStream)
                {
                    var depth = Int32.Parse(input.ReadLine());
                    if(depth > prevDepth)
                    {
                        counter++;
                    }
                    prevDepth = depth;
                }
                Console.WriteLine("Count: " + counter );
            }
        }
    }
}
