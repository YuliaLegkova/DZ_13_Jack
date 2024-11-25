using System;
using System.Collections.Generic;
using System.Linq;

namespace _JackHouse
{
        class Program
    {
        static void Main(string[] args)
        {
            var initialPoem = new List<string>();

            var part1 = new Part1();
            part1.AddPart(initialPoem);

            var part2 = new Part2();
            part2.AddPart(part1.Poem);

            var part3 = new Part3();
            part3.AddPart(part2.Poem);

            var part4 = new Part4();
            part4.AddPart(part3.Poem);

            var part5 = new Part5();
            part5.AddPart(part4.Poem);

            var part6 = new Part6();
            part6.AddPart(part5.Poem);

            var part7 = new Part7();
            part7.AddPart(part6.Poem);

            var part8 = new Part8();
            part8.AddPart(part7.Poem);

            var part9 = new Part9();
            part9.AddPart(part8.Poem);

            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Дом, который построил Джек");
            Console.WriteLine($"--------------------------");

            var parts = new Part[] { part1, part2, part3, part4, part5, part6, part7, part8, part9 };
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine($"\nЧасть {i + 1}:");
                Console.WriteLine(string.Join(Environment.NewLine, parts[i].Poem));
            }
        }
    }
}