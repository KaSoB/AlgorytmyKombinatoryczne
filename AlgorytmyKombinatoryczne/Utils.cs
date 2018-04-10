using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    static class Utils {
        public static List<int> ToBinary(int n) {
            var tmp = new List<int>();
            while (n != 0) {
                tmp.Add(n & 1);
                n = n >> 1;
            }
            tmp.Reverse();
            return tmp;
        }
        public static long Factorial(long n) {
            if (n == 0)
                return 1;
            long t = n;
            while (n-- > 2)
                t *= n;
            return t;
        }
        public static long FallingPower(long n, long p) {
            long t = 1;
            for (long i = 0 ; i < p ; i++)
                t *= n--;
            return t;
        }
        public static long BinomialCoeff(long n, long k) {
            if ((k < 0) || (k > n))
                return 0;
            k = (k > n / 2) ? n - k : k;
            return FallingPower(n, k) / Factorial(k);
        }

        public static List<int> Copy(this List<int> vs) {
            var list = new List<int>();
            list.AddRange(vs);
            return list;
        }
        public static List<List<int>> Repeat(this List<int> vs, int n) {
            var list = new List<List<int>>();
            for (int i = 0 ; i < n ; i++) {
                list.Add(Copy(vs));
            }
            return list;
        }

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
