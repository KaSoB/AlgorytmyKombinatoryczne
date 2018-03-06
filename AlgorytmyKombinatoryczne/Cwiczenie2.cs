using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    class Cwiczenie2 {
        public static void Task1() {
            /*
            1.Napisz program generujący wszystkie podzbiory zbioru {1, 2, . . . , n} w kolejności zgodnej
            z ich liczebnością (najpierw zbiór pusty, potem zbiory 1-elementowe, następnie 2-elementowe
            itd.). Algorytm nie musi być efektywny! Wykorzystaj program z zadania 4 z poprzednich
            ćwiczeń.
            */
            int n = int.Parse(Console.ReadLine());
            var values = Enumerable.Repeat(0, n).ToArray();
            int i;

            var results = new List<int[]>();

            do {
                i = n - 1;

                results.Add(values.Select(
                        (value, index) => new { Value = value, Index = index + 1 }).Where(x => x.Value != 0).Select(x => x.Index).ToArray());
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


            foreach (var item in results.OrderBy(y => y.Count())) {
                Console.WriteLine($"({string.Join(",", item)})");
            }
        }
        public static void Task2() {
            /*
            2.Napisz program generujący w porządku leksykograficznym wszystkie ciągi długości k zbudowane
            z liczb od 1 do n. Użyj algorytmu rekurencyjnego
            */
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            GenerateTask2(n, k, new List<int>());
        }
        private static void GenerateTask2(int n, int k, List<int> list) {
            if (k == 0) {
                Console.WriteLine($"({string.Join(",", list)})");
            } else {
                foreach (var index in Enumerable.Range(1, n)) {
                    GenerateTask2(n, k - 1, new List<int>(list) { index });
                }
            }
        }

        public static void Task3() {
            /*
            3.Napisz program obliczający pozycję podzbioru T ⊂ {1, . . . , n} w uporządkowaniu leksykograficznym
            (według wektorów charakterystycznych) podzbiorów zbioru {1, . . . , n}
            */
            int n = int.Parse(Console.ReadLine());
            List<int> list = Array.ConvertAll(
                Console.ReadLine().Replace(',', ' ').Split(' ').Where(y => y.Count() > 0).ToArray(),
                s => int.Parse(s)).ToList();
            list.Sort();


            int r = 0;
            if (list != null) {
                foreach (var item in list) {
                    r += (int) Math.Pow(2, n - item);
                }
            }

            Console.WriteLine(r);
        }

        public static void Task4() {
            /*
            4.Napisz program wyznaczający podzbiór T o zadanej pozycji r w uporządkowaniu leksykograficznym
            (według wektorów charakterystycznych) podzbiorów zbioru {1, . . . , n}.
            */
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
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
            Console.WriteLine($"({string.Join(",", result)})");

        }
    }
}
