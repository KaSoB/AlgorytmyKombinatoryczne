using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    public class Lesson05 {
        /// <summary>
        /// Napisz program wyznaczający następnik k-elementowego podzbioru T zbioru {1, . . . , n}
        /// w uporządkowaniu antyleksykograficznym podzbiorów k-elementowych.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static List<int> Task1(List<int> list, int n, int k) {
            list.Insert(0, n + 1); // wartownik

            int i = k - 1;

            // Znajdź indeks elementu od którego można wyznaczyć następnik
            while (i != 0 && list[i] == list[i - 1] - 1) {
                i = i - 1;
            }

            if (i == 0) {
                Console.WriteLine("Nie ma następnika");
                return null;
            } else {
                list[i] += 1;
                for (int j = i + 1 ; j < list.Count ; j++) {
                    list[j] = k - j + 1;
                }
            }
            list.RemoveAt(0); // pozbycie się wartownika

            Output.Subset(list);
            return list;
        }
        /// <summary>
        /// Napisz program obliczający rangę k-elementowego podzbioru T zbioru {1, . . . , n} w uporządkowaniu
        /// antyleksykograficznym podzbiorów k-elementowych.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int Task2(List<int> list, int n, int k) {
            int rank = 0;
            for (int i = 1 ; i <= k ; i++) {
                rank += (int) Utils.BinomialCoeff(list[i - 1] - 1, k + 1 - i);

            }
            Output.Value(rank);
            return rank;
        }

        /// <summary>
        /// Napisz program wyznaczający podzbiór T o randze r w uporządkowaniu antyleksykograficznym
        ///k-elementowych podzbiorów zbioru {1, . . . , n}.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static List<int> Task3(int n, int k, int r) {
            List<int> result = Enumerable.Range(1, k).ToList();
            result.Reverse();

            int x = n;
            for (int i = 1 ; i <= k ; i++) {
                while (Utils.BinomialCoeff(x, k - i + 1) > r) {
                    x -= 1;
                }
                result[i-1] = x + 1;
                r -= (int)Utils.BinomialCoeff(x, k - i + 1);
            }


            Output.Subset(result);
            return result;
        }
    }
}
