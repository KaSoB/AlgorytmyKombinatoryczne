using System;
using System.Collections.Generic;

namespace AlgorytmyKombinatoryczne {
    class Program {
        /// <summary>
        /// Zadania: http://berlinsk.home.amu.edu.pl/zajecia/ALK.html
        /// </summary>
        static void Main(string[] args) {
            // task1
            var input = new List<Tuple<int, int>> {
                new Tuple<int, int>(1, 4),
                new Tuple<int, int>(1, 7),
                new Tuple<int, int>(4, 5),
                new Tuple<int, int>(1, 6),
                new Tuple<int, int>(6, 8),
                new Tuple<int, int>(8, 3),
                new Tuple<int, int>(8, 2)
            };
            Output.Subset(Lesson12.Task1(input, 8));

            // task2
            Output.Tuples(Lesson12.Task2(new List<int>() { 1, 4, 1, 8, 8, 6 }));


            Console.ReadKey();
        }

    }
}
