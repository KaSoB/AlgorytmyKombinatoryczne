using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    public class Lesson07 {
        /// <summary>
        /// Napisz program generujący następnik permutacji p zbioru {1, . . . , n} w porządku leksykograficznym.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<int> Task1(List<int> list, int n) {
            list.Insert(0, 0); // wartownik!
            int index = list.Count - 2;

            while (index >= 0 && list[index] > list[index + 1]) {
                index--;
            }

            if (index != 0) {
                int indexToReplace = list.FindIndex(it => it == list.Skip(index + 1).Where(x => x > list[index]).Min());
                int tmp = list[indexToReplace];
                list[indexToReplace] = list[index];
                list[index] = tmp;
                list.Reverse(index + 1, list.Count - (index + 1));
            }
            list.RemoveAt(0); // usuwam wartownika!
            return list;
        }
        /// <summary>
        ///  Napisz program obliczający rangę permutacji p zbioru {1, . . . , n} w porządku leksykograficznym.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Task2(List<int> list, int n) {
            int r = 0;
            int firstItem;
            while (list.Any()) {
                firstItem = list[0];
                r += (firstItem - 1) * (int) Utils.Factorial(list.Skip(1).ToList().Count);
                for (int i = 1 ; i < list.Count ; i++) {
                    if (list[i] > firstItem) {
                        list[i]--;
                    }
                }
                list.RemoveAt(0);
            }

            return r;
        }
        /// <summary>
        /// Napisz program wyznaczający permutację p zbioru {1, . . . , n} o randze r w porządku leksykograficznym.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static List<int> Task3(int n, int r) {
            var dList = new List<int>();
            for (int i = 1 ; i < n ; i++) {
                var p = (r % Utils.Factorial(i + 1)) / Utils.Factorial(i);
                dList.Add((int) p);
            }

            int tmp;
            var list = new List<int>() { 1 };
            for (int j = 1 ; j < n ; j++) {
                tmp = dList[j - 1] + 1;

                for (int i = 0 ; i < list.Count ; i++) {
                    if (list[i] >= tmp) {
                        list[i]++;
                    }
                }
                list.Insert(0, tmp);
            }
            return list;
        }
        /// <summary>
        ///  Zaimplementuj algorytm Trottera-Johnsona generowania wszystkich permutacji zbioru {1, . . . , n} w porządku minimalnych zmian.
        /// </summary>
        /// <param name="n"></param>
        public static void Task4(int n) {
            GenerateTask4(n).ForEach(it => Output.Subset(it));
        }

        private static List<List<int>> GenerateTask4(int n) {
            if (n == 0) {
                return new List<List<int>>();
            } else if (n == 1) {
                return new List<List<int>>() { new List<int>() { 1 } };
            } else {
                var list = new List<List<int>>();

                bool isDescending = true;
                // Dla każdej podlisty z kroku n-1...
                foreach (var subset in GenerateTask4(n - 1)) {
                    // Utwórz odpowiednią ilość kopii tego elementu (odpowiednią czyli n razy)
                    var item = subset.Repeat(n);
                    // Poumieszczaj do każdej z nich raz element n w podanym szyku
                    ZigZagPush(item, n, isDescending);
                    // Zmień kierunek dla następnej podlisty 
                    isDescending = !isDescending;
                    // Dodaj obliczenia do wyniku
                    list.AddRange(item);
                }
                return list;
            }
        }

        /// <summary>
        ///  Metoda umieszcza do każdej podlisty element n malejąco(rosnąco) względem indeksów. 
        /// </summary>
        private static void ZigZagPush(List<List<int>> list, int element, bool descending) {
            // Note: Wszystkie podlisty są tej samej długości
            int indexToPushValue = (descending) ? list[0].Count : 0;
            for (int i = 0 ; i < list.Count ; i++) {
                list[i].Insert(indexToPushValue, element);
                indexToPushValue = (descending) ? indexToPushValue - 1 : indexToPushValue + 1;
            }
        }
    }
}
