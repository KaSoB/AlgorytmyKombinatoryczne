using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    public class Lesson2 {
        /// <summary>
        /// 1.Napisz program generujący wszystkie podzbiory zbioru {1, 2, . . . , n} w kolejności zgodnej
        /// z ich liczebnością(najpierw zbiór pusty, potem zbiory 1-elementowe, następnie 2-elementowe
        /// itd.). Algorytm nie musi być efektywny! Wykorzystaj program z zadania 4 z poprzednich
        ///  ćwiczeń.
        /// </summary>
        /// <param name="n"></param>
        public static void Task1(int n) {
            foreach (var item in GenerateSubsets(n).OrderBy(y => y.Count())) {
                Output.Subset(item);
            }
        }
        public static List<int[]> GenerateSubsets(int n) {
            var values = Enumerable.Repeat(0, n).ToArray();
            var results = new List<int[]>();
            int i;
            do {
                i = n - 1;

                results.Add(values.Select(
                        (value, index) => new { Value = value, Index = index + 1 })
                        .Where(x => x.Value != 0)
                        .Select(x => x.Index).ToArray());

                while (i >= 0 && values[i] == 1) {
                    i--;
                }

                if (i >= 0) {
                    values[i]++;
                    for (int j = i + 1 ; j < n ; j++) {
                        values[j] = 0;
                    }
                }

            } while (i >= 0);
            return results;
        }
        /// <summary>
        /// Napisz program generujący w porządku leksykograficznym wszystkie ciągi długości k zbudowane
        /// z liczb od 1 do n.Użyj algorytmu rekurencyjnego
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        public static void Task2(int n, int k) {
            GenerateTask2(n, k, new List<int>());
        }
        private static void GenerateTask2(int n, int k, List<int> list) {
            if (k == 0) {
                Output.Subset(list);
            } else {
                foreach (var index in Enumerable.Range(1, n)) {
                    GenerateTask2(n, k - 1, new List<int>(list) { index });
                }
            }
        }
        /// <summary>
        /// Napisz program obliczający pozycję podzbioru T ⊂ {1, . . . , n} w uporządkowaniu leksykograficznym
        /// (według wektorów charakterystycznych) podzbiorów zbioru {1, . . . , n }
        /// </summary>
        /// <param name="n"></param>
        /// <param name="list"></param>
        public static void Task3(int n, List<int> list) {
            list.Sort();

            int r = 0;
            foreach (var item in list) {
                r += (int) Math.Pow(2, n - item);
            }
            Output.Value(r);
        }
        /// <summary>
        /// Napisz program wyznaczający podzbiór T o zadanej pozycji r w uporządkowaniu leksykograficznym
        /// (według wektorów charakterystycznych) podzbiorów zbioru {1, . . . , n }.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="r"></param>
        public static void Task4(int n, int r) {
            var tmp = new List<int>();
            var result = new List<int>();

            while (r != 0) {
                tmp.Add(r % 2);
                r /= 2;
            }

            foreach (var item in tmp) {
                if (item == 1 && n >= 0) {
                    result.Add(n);
                }
                n--;
            }

            result.Reverse();
            Output.Subset(result);
        }
    }
}
