using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    static class Utils {


    }

    static class Output {
        public static void Subset(IEnumerable<int> values) {
            Console.WriteLine($"({string.Join(",", values)})");
        }
        public static void Print(Action<int[]> action) {
            Console.WriteLine($"({string.Join(",", action)})");
        }
        public static void Value(int n) {
            Console.WriteLine(n);
        }
    }
    static class Input {
        public static int Value() {
            if (!int.TryParse(Console.ReadLine(), out int value)) {
                Console.WriteLine("Wprowadzona wartość jest nieprawidłowa.");
            }
            return value;
        }

        public static List<int> Values() {
            return Array.ConvertAll(
               Console.ReadLine().Replace(',', ' ').Split(' ').Where(y => y.Count() > 0).ToArray(),
               s => int.Parse(s)).ToList();
        }
    }
}
