using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    public class Cwiczenie6 {
        public static void Task1(int n, int k) {
            /*
            1.Napisz program generujący wszystkie k-elementowe podzbiory zbioru {1, . . . , n} w porządku
            minimalnych zmian (revolving door).
            */
            foreach (var item in GenerateTask1(n, k)) {
                Output.Subset(item);
            }
        }
        private static List<List<int>> GenerateTask1(int n, int k) {
            if (k == 0) {  // Pusty zbiór  
                return new List<List<int>>();// TODO: element 
            } else if (n == k || n == 1) {  // 1 elementowa lista z elementami od 1 do k
                return new List<List<int>>() { Enumerable.Range(1, k).ToList() };
            } else if (k == 1) {
                var list = new List<List<int>>();
                for (int i = 1 ; i <= n ; i++) {
                    list.Add(new List<int>() { i });
                }
                return list;
            } else {
                var p1 = GenerateTask1(n - 1, k - 1);
                p1.ForEach(y => y.Add(n));
                p1.Reverse();
                var p2 = GenerateTask1(n - 1, k);
                p2.AddRange(p1);
                return p2;
            }
        }
        public static int Task2(List<int> list, int n, int k) {
            /*
            2.Napisz program obliczający rangę k-elementowego podzbioru T zbioru {1, . . . , n} w porządku
                minimalnych zmian podzbiorów k-elementowych.
            */

            int rank = 0;
            for (int i = 1 ; i <= k ; i++) {
                rank += (int) (Math.Pow(-1, k - i) * (Utils.BinomialCoeff(list[i - 1], i) - 1));
            }
            return rank;
        }

        public static List<int> Task3(int n, int k, int r) {
            /*
            3. Napisz program wyznaczający podzbiór T o randze r w porządku minimalnych zmian k-elementowych
                podzbiorów zbioru {1, . . . , n}.
           */
            List<int> result = new int[k].ToList();

            int x = n;
            for (int i = k ; i >= 1 ; i--) {
                while (Utils.BinomialCoeff(x, i) > r) {
                    x--;
                }
                result[i - 1] = x + 1;
                r = (int) Utils.BinomialCoeff(x + 1, i) - (r + 1);
            }
            return result;
        }
    }
}
