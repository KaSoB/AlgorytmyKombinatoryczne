using System;

namespace AlgorytmyKombinatoryczne {
    class Program {
        /// <summary>
        /// Zadania: http://www.staff.amu.edu.pl/~berlinsk/zajecia/ALK.html
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            var w = Lesson11.Task2(Input.Values(), Input.Value());
            Output.Subset(w);

            Console.ReadKey();
        }

    }
}
