using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    public class Cwiczenie3 {
        public static void Task1(int n) {
            /*
            1. Napisz program generujący wszystkie podzbiory zbioru {1, . . . , n} w porządku minimalnych
            zmian (Graya), wykorzystując wagi Hamminga lub różnicę symetryczną zbiorów.
            */
            bool[] gray = new bool[n];
            int w;
            for (int i = 0 ; i < Math.Pow(2, n) ; i++) {

                Output.Subset(
                    gray.Select((value, index) => new { Value = value, Index = index + 1 })
                    .Where(x => x.Value != false)
                    .Select(x => x.Index)
                    .ToArray());

                //HammingWeight
                if (gray.Count(y => y == true) % 2 == 0) {
                    w = n - 1;
                } else {
                    w = Math.Max(0, LastIndexOf(gray)-1);
                }
                gray[w] = !gray[w];
            }

        }
        public static int LastIndexOf(bool[] vs) {
            for (int i = vs.Count() - 1 ; i >= 0 ; i--) {
                if (vs[i]) {
                    return i;
                }
            }
            return -1;
        }
        public static void Task2(int n, List<int> list) {
            /*
            2. Napisz program obliczający rangę podzbioru T ⊂ {1, . . . , n} w uporządkowaniu minimalnych
            zmian (Graya) podzbiorów zbioru {1, . . . , n}.
           */
            list.Sort();

            var tmp = new int[n];
            foreach (var item in list) {
                tmp[item - 1] = 1;
            }

            int rank = 0;
            for (int i = 0 ; i < n ; i++) {
                tmp[i] = (rank + tmp[i]) % 2;
                rank = tmp[i];
            }

            int wynik = 0;
            for (int i = n - 1, j = 0 ; i >= 0 ; i--, j++) {
                wynik += tmp[i] * (int) Math.Pow(2, j);
            }
            Output.Value(wynik);
        }
        public static void Task3(int n, int r) {
            /*
            3.Napisz program wyznaczający podzbiór T o zadanej pozycji r w uporządkowaniu minimalnych
            zmian (Graya) podzbiorów zbioru {1, . . . , n}.
           */
            List<int> result = new List<int>(n);

            List<int> binary1 = ToBinary(r);
            ResizeList(binary1, n);

            List<int> binary2 = ToBinary(r / 2);
            ResizeList(binary2, n);

            for (int i = 0 ; i < n ; i++) {
                if ((binary1[i] ^ binary2[i]) == 1) { // XOR
                    result.Add(i + 1);
                }
            }

            Output.Subset(result);
        }

        public static void ResizeList(List<int> list, int size) {
            if (list.Count() < size) {
                list.InsertRange(0, Enumerable.Repeat(0, Math.Max(0, size - list.Count)));
            } else if (list.Count() > size) {
                list.RemoveRange(0, list.Count() - size);
            }

        }

        public static List<int> ToBinary(int n) {
            var tmp = new List<int>();
            while (n != 0) {
                tmp.Add(n & 1);
                n = n >> 1;
            }
            tmp.Reverse();
            return tmp;
        }


    }

}
