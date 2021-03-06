﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorytmyKombinatoryczne {
    public class Lesson01 {
        /// <summary>
        /// Napisz program generujący w porządku leksykograficznym wszystkie ciągi długości k zbudowane
        /// z liczb od 1 do n(użyj algorytmu iteracyjnego)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        public static void Task1(int n, int k) {
            var values = Enumerable.Repeat(1, k).ToArray();
            int i;

            do {
                i = k - 1;
                Output.Subset(values);

                while (i >= 0 && values[i] == n) {
                    i--;
                }

                if (i >= 0) {
                    values[i]++;
                    for (int j = i + 1 ; j < k ; j++) {
                        values[j] = 1;
                    }
                }

            } while (i >= 0);

        }
        /// <summary>
        /// Napisz program generujący wszystkie zbudowane z dodatnich liczb naturalnych ciągi długości
        /// k, w których i-ty wyraz jest nie większy od i dla i = 1, 2, . . . , k.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        public static void Task2(int n, int k) {
            var values = Enumerable.Repeat(1, k).ToArray();
            int i;

            do {
                i = k - 1;
                Output.Subset(values);

                while (i >= 0 && values[i] > i) {
                    i--;
                }

                if (i >= 0) {
                    values[i]++;
                    for (int j = i + 1 ; j < k ; j++) {
                        values[j] = 1;
                    }
                }

            } while (i >= 0);

        }
        /// <summary>
        /// Napisz program generujący w porządku leksykograficznym wszystkie rosnące ciągi długości
        /// k zbudowane z liczb od 1 do n(tzn.pierwszy ciąg to (1, 2, . . . , k), a ostatni to(n − k +
        ///     1, . . . , n − 1, n)).
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        public static void Task3(int n, int k) {
            var values = Enumerable.Range(1, k).ToArray();
            int i;

            do {
                i = k - 1;
                Output.Subset(values);
                int c = n + i - k + 1;
                while (i >= 0 && values[i] == c) {
                    i--;
                }

                if (i >= 0) {
                    values[i]++;
                    for (int j = i + 1 ; j < k ; j++) {
                        values[j] = values[j - 1] + 1;
                    }
                }

            } while (i >= 0);

        }
        /// <summary>
        /// Napisz program generujący wszystkie podzbiory zbioru {1, 2, . . . , n}, wykorzystując bijekcję
        /// między ciągami binarnymi długości n a tymi podzbiorami.
        /// </summary>
        /// <param name="n"></param>
        public static void Task4(int n) {
            var values = Enumerable.Repeat(0, n).ToArray();
            int i;

            do {
                i = n - 1;
                Output.Subset(values.Select(
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

        }
    }
}
