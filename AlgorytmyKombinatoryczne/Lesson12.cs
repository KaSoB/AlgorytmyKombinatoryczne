using System.Collections.Generic;

namespace AlgorytmyKombinatoryczne {
    public class Lesson12 {
        /// <summary>
        /// Napisz program generujący kod Prufera dla zadanego drzewa T o n wierzchołkach
        /// </summary>
        public static void Task1(int n, int k) {

        }

        /// <summary>
        /// Napisz program wyznaczający drzewo odpowiadające zadanemu kodowi Prufera L.
        /// </summary>
        public static void Task2(int n, int k) {

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
