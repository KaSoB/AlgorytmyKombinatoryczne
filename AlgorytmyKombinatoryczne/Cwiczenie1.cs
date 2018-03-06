using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorytmyKombinatoryczne {
    class Cwiczenie1 {
        public static void Task1() {
            /*
            1.Napisz program generujący w porządku leksykograficznym wszystkie ciągi długości k zbudowane
            z liczb od 1 do n (użyj algorytmu iteracyjnego)
            */
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var values = Enumerable.Repeat(1, k).ToArray();
            int i;

            do {
                i = k - 1;
                Console.WriteLine(string.Join(",", values));

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
        public static void Task2() {
            /*
            2.Napisz program generujący wszystkie zbudowane z dodatnich liczb naturalnych ciągi długości
            k, w których i-ty wyraz jest nie większy od i dla i = 1, 2, . . . , k.
            */
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var values = Enumerable.Repeat(1, k).ToArray();
            int i;

            do {
                i = k - 1;
                Console.WriteLine(string.Join(",", values));

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
        public static void Task3() {
            /*
            3.Napisz program generujący w porządku leksykograficznym wszystkie rosnące ciągi długości
            k zbudowane z liczb od 1 do n (tzn. pierwszy ciąg to (1, 2, . . . , k), a ostatni to (n − k +
            1, . . . , n − 1, n)).
            */
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var values = Enumerable.Range(1, k).ToArray();
            int i;

            do {
                i = k - 1;
                Console.WriteLine(string.Join(",", values));
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

        public static void Task4() {
            /*
            4.Napisz program generujący wszystkie podzbiory zbioru {1, 2, . . . , n}, wykorzystując bijekcję
            między ciągami binarnymi długości n a tymi podzbiorami.
            */
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var values = Enumerable.Repeat(0, k).ToArray();
            int i;


            do {
                i = k - 1;

                // lub pętla for...
                Console.WriteLine(string.Join(",",
                    values.Select(
                        (value, index) => new { Value = value, Index = index + 1 }).Where(x => x.Value != 0).Select(x => x.Index).ToArray()));

                while (i >= 0 && values[i] == 1) {
                    i--;
                }

                if (i >= 0) {
                    values[i]++;
                    for (int j = i + 1 ; j < k ; j++) {
                        values[j] = 0;
                    }
                }

            } while (i >= 0);

        }
    }
}
