using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    public class Lesson04 {
        /// <summary>
        /// Napisz program wyznaczający następnik k-elementowego podzbioru T zbioru {1, . . . , n}
        /// w uporządkowaniu leksykograficznym podzbiorów k-elementowych.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static List<int> Task1(List<int> list, int n, int k) {
            int i = k - 1;

            // Znajdź pierwszą pozycję i od prawej strony niezawierającą największego elementu 
            // (największego - max wartość jaką można umieścić w szyku t1<t2<t3<tn)
            while (list[i] == n - k + i + 1 && i != 0) {
                i = i - 1;
            }

            if (i == 0) {
                Console.WriteLine("Nie ma następnika");
            } else {
                // Zwiększ list[i] o 1;
                list[i] += 1;
                // pozostałe elementy - element poprzedni + 1
                for (int j = list.Count - 1 ; j < list.Count ; j++) {
                    list[j] = list[j - 1] + 1;
                }
            }

            Output.Subset(list);
            return list;
        }
        /// <summary>
        /// Napisz program obliczający rangę k-elementowego podzbioru T zbioru {1, . . . , n} w uporządkowaniu
        /// leksykograficznym podzbiorów k-elementowych.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int Task2(List<int> list, int n, int k) {
            // Note: Umieszczam wartownika, by numerować listę od 1
            list.Insert(0, 0); // Wartownik!
            list.Sort(); // Nie potrzebne

            int rank = 0;
            for (int i = 1 ; i <= k ; i++) {
                for (int j = list[i - 1] + 1 ; j <= list[i] - 1 ; j++) {
                    rank += (int) Utils.BinomialCoeff(n - j, k - i);
                }
            }
            list.RemoveAt(0); // usuwam Wartownika!
            Output.Value(rank);
            return rank;
        }
        /// <summary>
        /// Napisz program wyznaczający podzbiór T o randze r w uporządkowaniu leksykograficznym
        /// k-elementowych podzbiorów zbioru {1, . . . , n }.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static List<int> Task3(int n, int k, int r) {
            List<int> result = Enumerable.Range(1, k).ToList();

            int x = 1;
            for (int i = 1 ; i <= result.Count ; i++) {
                while (Utils.BinomialCoeff(n - x, k - i) <= r) {
                    r -= (int) Utils.BinomialCoeff(n - x, k - i);
                    x += 1;
                }
                result[i - 1] = x;
                x += 1;
            }


            Output.Subset(result);
            return result;
        }
    }
}
