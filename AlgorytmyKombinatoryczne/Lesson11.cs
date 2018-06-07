using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorytmyKombinatoryczne {
    public class Lesson11 {
        /// <summary>
        /// Napisz program obliczający metodą programowania dynamicznego liczbę podziałów liczby
        /// n na k składników, korzystając ze wzoru: P(n, k) = P(n − 1, k − 1) + P(n − k, k) dla k ¬ n,
        /// gdzie P(0, 0) = 1 oraz P(i, 0) = 0 dla i > 0.
        /// </summary>
        public static int Task1(int n, int k) {
            var result = new int[n + 1, k + 1];

            // P(0,0) = 1;
            result[0, 0] = 1;

            for (int i = 1 ; i <= n ; i++) {
                for (int j = 1 ; j <= k ; j++) {
                    if (i - j < 0) {
                        result[i, j] = result[i - 1, j - 1];
                    } else {
                        result[i, j] = result[i - 1, j - 1] + result[i - j, j];
                    }

                }
            }

            return result[n, k];
        }
        /// <summary>
        /// Napisz program generujący podział sprzężony do zadanego podziału (a1, . . . , am) liczby n
        /// </summary>
        public static int[] Task2(List<int> list, int n) {
            int[] result = new int[list[0]]; // liczba składników = zerowy element;

            for (int i = 0 ; i < result.Length ; i++) {
                // zlicz liczbę elementów z danych wejsciowych
                result[i] = list.Count;

                // dekrementuj wszystkie elementy z danych wejściowych
                for (int j = 0 ; j < list.Count ; j++) {
                    list[j] -= 1;
                }
                // i usuń te elementy które są <= 0
                list.RemoveAll(it => it <= 0);
            }
            return result;
        }

        /// <summary>
        /// Napisz program generujący wszystkie podziały liczby n w postaci normalnej za pomocą
        /// algorytmu rekurencyjnego.Wykorzystaj następującą procedurę:
        /// PODZIAŁ (n, b, m)
        ///   if n == 0 then
        ///     wypisz (a1, . . . , am)
        ///   else
        ///     for i = 1 to min(b, n) do
        ///         am+1 = i
        ///         PODZIAŁ(n − i, i, m + 1)
        /// W powyższym pseudokodzie a1, . . . , am są już wybranymi składnikami podziału, natomiast
        /// parametr b jest górnym ograniczeniem wartości następnego generowanego składnika.
        /// </summary>
        public static void Task3(int n) {
            GenerateTask3(new int[n], n, n, 0);
        }

        /// <param name="a">Gotowy kawałek podziału</param>
        /// <param name="n">Liczba do podziału</param>
        /// <param name="b">Max element</param>
        /// <param name="m">Ile już mamy składników</param>
        private static void GenerateTask3(int[] a, int n, int b, int m) {
            if (n == 0) {
                Output.Subset(a.Take(m));
            } else {
                for (int i = 1 ; i <= Math.Min(b, n) ; i++) {
                    a[m] = i;
                    GenerateTask3(a, n - i, i, m + 1);
                }
            }
        }


        /// <summary>
        /// Napisz program generujący wszystkie podziały liczby n na k składników. Wykorzystaj algorytmy z zadań 2 i 3.
        /// </summary>
        public static void Task4(int n, int k) {
            int[] vs = new int[n];
            vs[0] = k;
            GenerateTask4(vs, n - k, k, 1);
        }

        /// <param name="a">Gotowy kawałek podziału</param>
        /// <param name="n">Liczba do podziału</param>
        /// <param name="b">Max element</param>
        /// <param name="m">Ile już mamy składników</param>
        private static void GenerateTask4(int[] a, int n, int b, int m) {
            if (n == 0) {
                Output.Subset(Task2(a.Take(m).ToList(), m));
            } else {
                for (int i = 1 ; i <= Math.Min(b, n) ; i++) {
                    a[m] = i;
                    GenerateTask4(a, n - i, i, m + 1);
                }
            }
        }
    }
}
