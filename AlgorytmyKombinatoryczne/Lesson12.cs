using System;
using System.Collections.Generic;

namespace AlgorytmyKombinatoryczne {
    public class Lesson12 {
        /// <summary>
        /// Napisz program generujący kod Prufera dla zadanego drzewa T o n wierzchołkach
        /// </summary>
        public static double Task1(List<int> list, int n) {
            double k = 0F;
            for (int i = 0 ; i <= n - 3 ; i++) {
                k += (list[i] - 1) * Math.Pow(n, n - 3 - i);
            }
            return k;
        }

        /// <summary>
        /// Napisz program wyznaczający drzewo odpowiadające zadanemu kodowi Prufera L.
        /// </summary>
        public static List<Tuple<int, int>> Task2(List<int> list, int n) {
            List<Tuple<int, int>> vs = new List<Tuple<int, int>>();
            int[] d = new int[n];
            for (int i = 0 ; i <= n - 1 ; i++) {
                d[i] = 1;
            }
            for (int i = 0 ; i <= n - 3 ; i++) {
                d[list[i]] += 1;
            }
            list[n - 3] = 1; // n-2 pytać
            for (int i = 0 ; i <= n - 3 ; i++) {
                int x = n - 1;
                while (d[x] != 1) {
                    x -= 1;
                }
                int y = list[i];
                d[x] -= 1;
                d[y] -= 1;
                vs.Add(new Tuple<int, int>(x, y));
            }
            return vs;
        }

        /// <summary>
        /// Napisz program obliczający rangę kodu Prufera L.
        /// </summary>
        public static int Task3(List<int> list, int n) {
            int r = 0;
            int p = 1;
            for (int i = n - 3 ; i >= 0 ; i--) {
                r += p * (list[i] /*- 1*/); // Pytać czemu -1
                p *= n;
            }
            return r;
        }

        /// <summary>
        /// Napisz program wyznaczający kod Prufera długości n − 2 o randze r.
        /// </summary>
        public static int[] Task4(int r, int n) {
            var tmp = new int[n - 2];

            for (int i = n - 3 ; i >= 0 ; i--) {
                tmp[i] = (r % n); /*+ 1;*/ // pytać czemu + 1
                r = (r - tmp[i] /*+ 1*/) / n;
            }

            return tmp;
        }
    }
}
